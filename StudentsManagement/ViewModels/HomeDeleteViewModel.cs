using StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.ViewModels
{
    public class HomeDeleteViewModel:StudentCreateViewModel
    {
       
        public int Id { get; set; }
       public string CurrentPhotoPath { get; set; }
    }
}
