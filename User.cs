using System;
using System.Collections.Generic;

namespace TodoApi
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
    }
}
