using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage ="Name cannot be longer than 20 characters")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        public string Class { get; set; } 
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Wrong email format")]
        
        public string Email { get; set; }
        
        public string PicturePath { get; set; }

        [Required]
        public Faculty Faculty { get; set; }
    }
}
