using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.ViewModels
{
    public class EditRoleViewModel
    {

        public EditRoleViewModel()
        {
            Users = new List<string>();
        }


        public string RoleId { get; set; }
        
        [Required(ErrorMessage = "You have to add the role name!")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
