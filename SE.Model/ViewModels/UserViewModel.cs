using SE.Common;
using System;

namespace SE.Model.ViewModels
{
    public class UserViewModel
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public bool IsConfirmed { get; set; }
    }
}
