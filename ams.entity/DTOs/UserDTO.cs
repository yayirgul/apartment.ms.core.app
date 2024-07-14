namespace ams.entity.DTOs
{
    public class UserDTO
    {
        public class LoginDTO
        {
            public string Email { get; set; } = null!;
            public string Password { get; set; } = null!;
            public bool RememberMe { get; set; }
        }
    }
}
