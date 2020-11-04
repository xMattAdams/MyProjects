using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsManagement.ViewModels;

namespace StudentsManagement.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;


        public UserAccountController(UserManager<IdentityUser>userManager, SignInManager<IdentityUser>signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    
    [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerModel)
        {
            if (ModelState.IsValid)
            {
                var newUser = new IdentityUser { UserName = registerModel.Email, Email = registerModel.Email };
                var response = await userManager.CreateAsync(newUser, registerModel.Password);

                if (response.Succeeded)
                {
                    await signInManager.SignInAsync(newUser, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                 foreach(var error in response.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            
            return View(registerModel);
        }


    }
}