using System.ComponentModel.DataAnnotations;

namespace UTEHY.DatabaseCoursePortal.Api.Models.Account
{
    public class LoginEmailRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(40)]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
