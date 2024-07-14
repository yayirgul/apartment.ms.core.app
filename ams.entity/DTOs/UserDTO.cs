namespace ams.entity.DTOs
{
    public class UserDTO
    {
		public class LoggedDTO 
		{
			public Guid Id { get; set; }
			public string Firstname { get; set; } = null!;
			public string Lastname { get; set; } = null!;
			public string Email { get; set; } = null!;
			public bool EmailConfirmed { get; set; }
			public string PhoneNumber { get; set; } = null!;
			public int AccessFailedCount { get; set; }
			public string Role { get; set; } = null!;
		}

		public class LoginDTO
        {
            public string Email { get; set; } = null!;
            public string Password { get; set; } = null!;
            public bool RememberMe { get; set; }
        }
    }
}
