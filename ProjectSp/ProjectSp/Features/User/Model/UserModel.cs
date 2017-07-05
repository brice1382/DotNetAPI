using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSp.Features.User.Model
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }
    }
}