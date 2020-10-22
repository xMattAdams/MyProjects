using Microsoft.AspNetCore.Http;
using StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.ViewModels
{
    public class StudentEditViewModel:StudentCreateViewModel
    {
        public int Id { get; set; }
        public string ActualPhotoPath { get; set; } 

        
    }

}

