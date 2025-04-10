﻿namespace ams.entity.DTOs
{
    public class UserDTO
    {
        public class ComboBox
        {
            public Guid Id { get; set; }
            public string? DisplayName { get; set; }
        }
        
        public class Add
        {
            public Guid Id { get; set; }
            public Guid? AccountId { get; set; }
            public Guid? CreateUser { get; set; }
            public DateTime? ModifiedTime { get; set; }
            public bool IsActive { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string? Email { get; set; }
            public string? Phone { get; set; }
            public string? Password { get; set; }
            public string? ConfirmPassword { get; set; }
            public Guid RoleId { get; set; }
        }

        public class Edit
        {
            public Guid Id { get; set; }
            public Guid? ModifiedUser { get; set; }
            public DateTime? ModifiedTime { get; set; }
            public bool IsActive { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string? Email { get; set; }
            public string? Phone { get; set; }
            public Guid RoleId { get; set; }
        }

        public class Detail
        {
            public Guid Id { get; set; }
            public DateTime? ModifiedTime { get; set; }
            public bool IsActive { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string? Email { get; set; }
            public string? Phone { get; set; }
            public Guid RoleId { get; set; }
        }

        public class Table
        {
            public Guid Id { get; set; }
            public Guid? AccountId { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string Email { get; set; } = null!;
            public int EmailConfirmed { get; set; } = 0;
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
