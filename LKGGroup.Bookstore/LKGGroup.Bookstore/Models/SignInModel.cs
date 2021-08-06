using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Models
{
    public class SignInModel
    {

        [Required(ErrorMessage = "Username should be put there")]
        [Display(Name = "Please enter your username or email")]
        [EmailAddress(ErrorMessage = "Please enter valid username or email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
