using System.ComponentModel.DataAnnotations;

namespace Onboarding.API.Models.DTO
{
    public class SignUpRequestDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.[A-Za-z]{2,}$",ErrorMessage = "Email should be in this format: name@example.com")]
        [StringLength(100, ErrorMessage = "Email must be 100 characters or fewer")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(64, MinimumLength = 8, ErrorMessage = "Password must be 8 to 64 characters")]
        [RegularExpression(@"^\S+$", ErrorMessage = "Password cannot contain spaces")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
