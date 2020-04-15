using SE.Common;
using SE.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SE.DAL
{
    public static class DBInitializer
    {
        public static void Initialize(SEContext context)
        {
            IList<User> defaultUsers = new List<User>();

            if (!context.Users.Any())
            {
                defaultUsers.Add(new User { 
                    Name = "admin", 
                    Surname = "admin", 
                    Email = "admin@admin.com",
                    Password = Crypto.Sha256("admin" + "admin@admin.com"), 
                    Role = Enums.Role.Admin, 
                    IsConfirmed = true 
                });

                defaultUsers.Add(new User
                {
                    Name = "Max",
                    Surname = "Grechuha",
                    Email = "max.grechuha@mail.ru",
                    Password = Crypto.Sha256("123123" + "max.grechuha@mail.ru"),
                    Role = Enums.Role.User,
                    IsConfirmed = true
                });

                context.Users.AddRange(defaultUsers);
            }

            context.SaveChanges();
        }
    }
}
