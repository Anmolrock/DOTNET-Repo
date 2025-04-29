using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [AnmolValidation]
        public string Message { get; set; }
    }
}