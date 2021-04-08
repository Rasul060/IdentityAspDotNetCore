using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Identity.Models.Domain;
using Identity.ViewModel.UserViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Identity.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> SignIn(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
              User user= new User
              {
                  UserName = model.UserName,
                  Email = model.Email
              };
              var result = await _userManager.CreateAsync(user, model.Password);
              if (result.Succeeded)
                  return RedirectToAction("Index");
              else
              {
                  result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
              }
            }

            return View(model);
        }
    }
}
