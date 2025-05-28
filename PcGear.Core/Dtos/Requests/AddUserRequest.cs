﻿namespace PcGear.Core.Dtos.Requests
{
    public class AddUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}
