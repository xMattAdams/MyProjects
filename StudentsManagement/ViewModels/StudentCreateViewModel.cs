using Microsoft.AspNetCore.Http;
using StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.ViewModels
{
    public class StudentCreateViewModel
    {
        
        [Required]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters")]
        public string Name { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Surname cannot be longer than 40 characters")]
        public string Surname { get; set; }
        
        [Required]
        public string Class { get; set; }
        
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Wrong email format")]
        public string Email { get; set; }

        public IFormFile Picture { get; set; }

        [Required]
        public Faculty Faculty { get; set; }
    }
}
