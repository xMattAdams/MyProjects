﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Province { get; set; }
        public string City { get; set; }
    }
}
