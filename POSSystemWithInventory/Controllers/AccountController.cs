using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using POSSystemWithInventory.EntityModel;
using POSSystemWithInventory.Models;
using POSSystemWithInventory.RepositoryPattern.Interfaces.IUnitOfWork;

namespace POSSystemWithInventory.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IImageProcessing image;

        public AccountController(UserManager<ApplicationUser>userManager, SignInManager<ApplicationUser> signInManager, IImageProcessing imageProcessing)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.image = imageProcessing;
        }

        #region Special User Creation
        private async Task SuperAdminCretation()
        {
            var user = new ApplicationUser()
            {
                Email = "superadmin@gmail.com",
                UserName = "superadmin@gmail.com",
                PhotoUrl = "/superAdmin.png",
                Name = "Super Admin",
            };
            var allUser = userManager.Users.ToList();
            if (allUser.Count == 0)
            {
                var result = await userManager.CreateAsync(user, "superadmin@123");
            }
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            await SuperAdminCretation();
            return View();
        }
        
        
        #region Register User
        [HttpPost]
        public async Task<IActionResult> RegisterUser(AdminAccountVM adminAccountVM)
        {
            var user = new ApplicationUser()
            {
                Name = adminAccountVM.Name,
                UserName = adminAccountVM.Email,
                Email = adminAccountVM.Email,
            };

            if (adminAccountVM.Photo != null)
            {
                var fileName = ContentDispositionHeaderValue.Parse(adminAccountVM.Photo.ContentDisposition).FileName.Trim('"').Replace(" ", string.Empty);
                List<string> separate = fileName.Split(".").ToList();
                fileName = separate[0] + DateTime.Now.ToString("dddd_dd_MMMM_yyyy_HH_mm_ss") + "." + separate[1];
                string path = image.GetImagePath(fileName, "AdminAccount");
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    adminAccountVM.Photo.CopyTo(stream);
                }
                user.PhotoUrl = image.GetImagePathForDb(path);
            }


            var result = await userManager.CreateAsync(user, adminAccountVM.Password);
            if (result.Succeeded)
            {
                return Json(true);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return Json(ModelState);
            }
        }
        #endregion

        #region Login Logout
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginVM user)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
