using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Models;
using StudentsManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Controllers
{
    [Route("[controller]/[action]")] //token controller is used to for the situation when we change the name of controller that we used
    public class HomeController: Controller
    {

        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository )
        {
            _studentRepository = studentRepository;
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


    }
}
