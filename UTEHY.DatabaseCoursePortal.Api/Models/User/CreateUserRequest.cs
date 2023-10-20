namespace UTEHY.DatabaseCoursePortal.Api.Models.User
{
    public class CreateUserRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public string RoleId { get; set; }
    }
}
