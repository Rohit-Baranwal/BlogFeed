using System.ComponentModel.DataAnnotations;

namespace BlogFeed.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Email must be in proper format")]
        [Required(ErrorMessage = "Email is a require field!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is a require field!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
