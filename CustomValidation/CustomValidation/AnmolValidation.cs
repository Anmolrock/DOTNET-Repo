using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CustomValidation
{
    public class AnmolValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string messsage = value.ToString();
                if (messsage.Contains("Anmol"))
                {
                    return ValidationResult.Success;
                }
            }
            //Error Kaha aa rahi h uske liye ValidationContext ka use karte hai neeche dekho 
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field Must Contain Anmol";
            return new ValidationResult(ErrorMessage);
        }
    }
}