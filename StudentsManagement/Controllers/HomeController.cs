using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Controllers
{
    public class HomeController: Controller
    {

        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository )
        {
            _studentRepository = studentRepository;
        }
        
        
        public string Index()
        {
           return _studentRepository.GetStudent(1).Name;
        }

        public ViewResult Details()
        {
            Student model = _studentRepository.GetStudent(1);
            ViewData["Student"] = model;
            ViewData["PageTitle"] = "Student Details";
            return View(model);
        }


    }
}
