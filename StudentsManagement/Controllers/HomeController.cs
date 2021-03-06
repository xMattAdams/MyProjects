﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentsManagement.Models;
using StudentsManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Controllers
{
    
    [Route("[controller]/[action]")] //token controller is used for the situation when we change the name of controller that was used
    public class HomeController: Controller
    {

        private readonly IStudentRepository _studentRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IStudentRepository studentRepository, IHostingEnvironment hostingEnvironment )
        {
            _studentRepository = studentRepository;
            this.hostingEnvironment = hostingEnvironment;
        }
        
        [Route("~/Home")] // the page loads even if we won't navigate to the special location
        [Route("~/")]
        public ViewResult Index()
        {
            var model= _studentRepository.GetAllStudents();
            return View(model);
        }

        [Authorize]
        [Route("{id?}")]
        public ViewResult Details(int? id)
        {
            

            Student student = _studentRepository.GetStudent(id.Value);
            if (student == null)
            {
                Response.StatusCode = 404;
                return View("StudentNotFound", id.Value);
            }
            
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = student,   
                PageTitle = "Student Details"
            };
            
            return View(homeDetailsViewModel);
        }
        
        
        [HttpGet]   //returns the view of creating the student
        [Authorize(Roles ="Admin")]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(StudentCreateViewModel studentModel) //adds a student to the list
        {
            if (ModelState.IsValid)
            {
                string diffFileName = PhotoUpload(studentModel);
               
                
                
                Student newStudent = new Student
                {
                    Name = studentModel.Name,
                    Surname=studentModel.Surname,
                    Email=studentModel.Email,
                    Class=studentModel.Class,
                    Faculty=studentModel.Faculty,
                    PicturePath=diffFileName
                };
                _studentRepository.Add(newStudent);
                return RedirectToAction("details", new { id = newStudent.Id });
            }

            return View();
        
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult Edit(int id)
        {
            Student student = _studentRepository.GetStudent(id);
            StudentEditViewModel newStudent = new StudentEditViewModel
            {
                Id=student.Id,
                ActualPhotoPath=student.PicturePath,
                Name=student.Name,
                Surname=student.Surname,
                Class=student.Class,
                Email=student.Email,
                Faculty=student.Faculty
            };
            return View(newStudent);
        }




        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(StudentEditViewModel studentModel) 
        {
            if (ModelState.IsValid)
            {
                Student student = _studentRepository.GetStudent(studentModel.Id);
                student.Surname = studentModel.Surname;
                student.Email = studentModel.Email;
                student.Faculty = studentModel.Faculty;
                student.Class = studentModel.Class;
                student.Name = studentModel.Name;
                if (studentModel.Picture != null)
                {


                    if (studentModel.ActualPhotoPath != null)
                    {
                        string fPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", studentModel.ActualPhotoPath);
                        System.IO.File.Delete(fPath);
                    }

                    student.PicturePath = PhotoUpload(studentModel);
                }

                _studentRepository.Update(student);
                return RedirectToAction("details", new { id = student.Id });
            }

            return View();

        }

        [Authorize(Roles = "Admin")]
        [Route("{id}")]
        [HttpGet]
        public ViewResult Delete(int Id)
        {
            var student = _studentRepository.GetStudent(Id);
            if (student == null)
            {
                Response.StatusCode = 404;
                return View("StudentNotFound", Id);
            }

            HomeDeleteViewModel homeDeleteViewModel = new HomeDeleteViewModel()
            {
                Id=student.Id,
                Class=student.Class,
                Email=student.Email,
                Faculty=student.Faculty,
                Name=student.Name,
                Surname=student.Surname,
                CurrentPhotoPath=student.PicturePath
                
            };
            return View(homeDeleteViewModel);
        }

        [Authorize(Roles = "Admin")]
        [Route("{id}")]
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            
            if (ModelState.IsValid)
            {
                Student student = _studentRepository.GetStudent(id.Value);
           

                _studentRepository.Delete(student.Id);
               
            }

            return RedirectToAction("index", "home");
        }



        private string PhotoUpload(StudentCreateViewModel studentModel)
        {
            string diffFileName =null;
            if (studentModel.Picture != null)
            {

                string Folder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                diffFileName = Guid.NewGuid().ToString() + "_" + studentModel.Picture.FileName; 
                string fileDirection = Path.Combine(Folder, diffFileName);
                using (var newStream = new FileStream(fileDirection, FileMode.Create))
                    
                {
                    studentModel.Picture.CopyTo(newStream);
                }
                

            }
            return diffFileName;
        }






        
    }
}
