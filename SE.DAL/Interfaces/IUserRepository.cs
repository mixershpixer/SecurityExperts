using SE.DAL.Entities;

namespace SE.DAL.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool Login(string email, string password);
        User Registration(User user);
        string GetRole(string email);
        void ConfirmEmail(string email);
    }
}
