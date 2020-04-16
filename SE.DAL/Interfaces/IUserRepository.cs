using SE.DAL.Entities;
using System;

namespace SE.DAL.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUserById(Guid id);
        bool Login(string email, string password);
        User Registration(User user);
        string GetRole(string email);
        void ConfirmEmail(string email);
    }
}
