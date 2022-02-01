using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime thisDay = DateTime.Today;
            // if(value[DayOfYear] == thisDay.DayOfYear)
            if(((System.DateTime)value).DayOfYear != thisDay.DayOfYear) {
                return new ValidationResult("You must put todays date!");
            }
            return ValidationResult.Success;
        }
    }
}