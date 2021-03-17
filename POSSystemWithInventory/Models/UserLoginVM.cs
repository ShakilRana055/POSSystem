using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystemWithInventory.Models
{
    public class UserLoginVM
    {
        public UserLoginVM()
        {
            ErrorMessage = "Username or Password is incorrect";
        }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string ErrorMessage { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public bool RememberMe { get; set; }
    }
}
