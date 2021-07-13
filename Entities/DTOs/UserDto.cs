﻿using Core.Entities;

namespace Entities.DTOs
{
    public class UserDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  CompanyName { get; set; }
        public string Email { get; set; }

    }
}
