using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Models;
using StudentsManagement.ViewModels;
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
        
        
        public ViewResult Index()
        {
            var model= _studentRepository.GetAllStudents();
            return View(model);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(1),
                PageTitle = "Student Details"
            };
            
            return View(homeDetailsViewModel);
        }


    }
}
