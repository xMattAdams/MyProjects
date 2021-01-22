using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Models;
using StudentsManagement.ViewModels;

namespace StudentsManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public AccountController(UserManager<ApplicationUser>userManager, SignInManager<ApplicationUser>signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Login(LoginViewModel loginModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                
                var response = await signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberUser, false);

                if (response.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl)) //localredirect przekierowuje tylko do lokalnych linkow z aplikacji, co zapobiega atakom hakerow, chcacych wykrasc nasze dane logowania poprzez przekierowanie do swoich stron poprze zmiane returnurla
                    {
                        return Redirect(returnUrl); 
                    }

                    else
                    {
                        return RedirectToAction("index", "home");
                    }

                    
                }
               
                {
                    ModelState.AddModelError("", "Invalid login procedure");
                }
            }

            return View(loginModel);
        }




        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
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
                var newUser = new ApplicationUser { UserName = registerModel.Email, Email = registerModel.Email, Province=registerModel.Province, City=registerModel.City };
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




        [HttpPost][HttpGet]
        public async Task<IActionResult> EmailUniqueCheck(string email)
        {
            var userEmail = await userManager.FindByEmailAsync(email);

            if (userEmail == null)
            {
                return Json(true);
        
            }

            else
            {
                return Json($"This email address is currently in use. Choose different email address!");
            }
        }




    }
}