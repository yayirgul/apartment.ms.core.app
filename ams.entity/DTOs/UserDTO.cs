namespace ams.entity.DTOs
{
    public class UserDTO
    {
        public class ComboList
        {
            public Guid Id { get; set; }
            public string? DisplayName { get; set; }
        }

        public class List
        {
            public Guid Id { get; set; }
            public Guid? AccountId { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string Email { get; set; } = null!;
            public string? Role { get; set; }
            public string? DisplayName { get; set; }
            public int IsActive { get; set; }
            public string? _CreateTime { get; set; }
            public string? _ModifiedTime { get; set; }
        }

        public class User
        {
            public Guid Id { get; set; }
            public Guid? AccountId { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string Email { get; set; } = null!;
        }

        public class Logged
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

		public class Login
        {
            public string Email { get; set; } = null!;
            public string Password { get; set; } = null!;
            public bool RememberMe { get; set; }
        }
    }
}
