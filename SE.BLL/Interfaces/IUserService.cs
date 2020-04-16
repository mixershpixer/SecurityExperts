using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetAll();
        Task<UserViewModel> GetUserById(Guid id);
        Task<UserViewModel> GetUserByEmail(string email);
        Task<Guid> GetUserIdByEmail(string email);
        Task<LoginViewModel> Login(LoginViewModel model);
        Task<RegistrationViewModel> Registration(RegistrationViewModel model);
        string GetRole(string email);
        Task<bool> IsConfirmed(string email);
        Task<bool> IsExists(string email);
        void ConfirmEmail(string email);
    }
}
