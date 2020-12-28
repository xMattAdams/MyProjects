
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update;
using StudentsManagement.Models;
using StudentsManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Controllers
{
    public class AdminController:Controller

    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [Authorize][HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task <IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("GetRoles", "Admin");
                }
            
           foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            
            }

            
            
            return View(model);
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

   [HttpGet]
    public async Task<IActionResult>EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Couldn't find the role with Id = {id}";
                return View("ErrorNotFound");
            }

            var model = new EditRoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name
            };
       
        
        foreach(var user in userManager.Users)
            {
              if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.RoleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Couldn't find the role with Id = {model.RoleId}";
                return View("ErrorNotFound");
            }
            else
            {
                role.Name = model.RoleName;
              var updateResult = await roleManager.UpdateAsync(role);

                if (updateResult.Succeeded)
                {
                    return RedirectToAction("GetRoles");
                }
                 foreach(var error in updateResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            
        }

    }
}
