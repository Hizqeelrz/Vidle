using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidle.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        //IsValid has 2 Overloads, With ValidationContext Overload it also give validation for other properties
        // ObjectInstance give us the access to the containing class which is customer
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unkown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            // Value here mean Birthdate is Nullable datetimeas we created properties in our customer Model

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be 18 Years of age to be a Member");
        }
    }
}