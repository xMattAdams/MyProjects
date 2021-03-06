﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.ViewModels
{
    public class RegisterViewModel
    {


        [Required]
        [EmailAddress]
        [Remote(action:"EmailUniqueCheck", controller:"Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm your password")]
        [Compare("Password", ErrorMessage ="The confirmed password does not match the actual password")]
        public string PasswordConfirm { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
    }
}
