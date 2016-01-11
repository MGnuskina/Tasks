using Autorization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCGameApplication.Models
{
	public class UserLogInViewModel
	{
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
	}

    public class UserRegisterViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Repeat Password")]
        [Compare("Password")]
        public string PasswordAgain { get; set; }
    }

}