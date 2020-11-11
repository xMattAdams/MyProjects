using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsManagement.ViewModels;

namespace StudentsManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;


        public AccountController(UserManager<IdentityUser>userManager, SignInManager<IdentityUser>signInManager)
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
        public async Task<IActionResult>Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var loggUser = new IdentityUser { UserName = loginModel.Email, PasswordHash = loginModel.Password };
                var response = await signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberUser, false);

                if (response.Succeeded)
                {
                   
                    return RedirectToAction("index", "home");
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