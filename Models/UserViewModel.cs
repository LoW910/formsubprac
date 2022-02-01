using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        public User() {

        }

        [Required]
        [MinLength(4)]
        public string FirstName {get; set;} = string.Empty;

        [Required]
        [MinLength(4)]
        public string LastName {get;set;} = string.Empty;

        [Required]
        [RegularExpression(@"0-9")]
        public int Age {get;set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}


    }
}