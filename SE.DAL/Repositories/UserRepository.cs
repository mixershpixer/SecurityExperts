using SE.Common;
using SE.DAL.Entities;
using SE.DAL.Interfaces;
using System;
using System.Linq;

namespace SE.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SEContext context) : base(context)
        {
        }

        public bool Login(string email, string password)
        {
            string passwordHash = Crypto.Sha256(password + email);

            var user = DbSet.Where(u => u.Email == email && u.Password == passwordHash).FirstOrDefault();

            return user != null;
        }

        public User Registration(User user)
        {
            var pass = DbSet.Add(user);

            Context.SaveChanges();

            var passenger = DbSet.Where(p => p.Email == user.Email).FirstOrDefault();

            return passenger;
        }

        public string GetRole(string email)
        {
            return DbSet.Where(p => p.Email == email).FirstOrDefault().Role.ToString("g");
        }

        public void ConfirmEmail(string email)
        {
            var user = DbSet
                .Where(p => p.Email == email)
                .FirstOrDefault();

            if (user == null)
                throw new ApplicationException($"Can't find user with email = {email}");

            user.IsConfirmed = true;

            Context.SaveChanges();
        }

        public User GetUserById(Guid id)
        {
            var user = DbSet.Where(p => p.Id == id).FirstOrDefault();

            if (user == null)
                throw new ApplicationException($"Can't find user with id = {id}");

            return user;
        }
    }
}
