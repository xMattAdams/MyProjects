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
    [Route("[controller]/[action]")] //token controller is used to for the situation when we change the name of controller that we used
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

        [Route("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(id??1), //if the incoming int value is not null, use this value, if it's null, use 1 as value  
                PageTitle = "Student Details"
            };
            
            return View(homeDetailsViewModel);
        }
        [Route("~/Home/Create")]
       [HttpGet]   //zwraca widok formatki, gdzie tworzymy studenta
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreateViewModel studentModel) //dodaje studenta do listy
        {
            if (ModelState.IsValid)
            {
                string diffFileName = null;
                if (studentModel.Picture != null)
                {
                   string Folder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                   diffFileName = Guid.NewGuid().ToString() + "_" + studentModel.Picture.FileName; //uploaded filenames will be unique
                  string fileDirection= Path.Combine(Folder, diffFileName);
                    studentModel.Picture.CopyTo(new FileStream(fileDirection, FileMode.Create));

                }
                Student newStudent = new Student
                {
                    Name = studentModel.Name,
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
    }
}
