namespace UTEHY.DatabaseCoursePortal.Api.Models.Auth
{
    public class LoginResult
    {
        public string? Token { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? Expiration { get; set;}
    }
}
