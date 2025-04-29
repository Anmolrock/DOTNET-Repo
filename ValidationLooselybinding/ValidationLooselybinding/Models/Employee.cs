using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationLooselybinding.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter Your First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Valid Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Valid Age")]
        [Range(18,100)]
        public int Age { get; set; }

    }
}