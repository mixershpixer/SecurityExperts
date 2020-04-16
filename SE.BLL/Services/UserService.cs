using SE.BLL.Interfaces;
using SE.Common;
using SE.DAL.Entities;
using SE.DAL.Interfaces;
using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            var users = await _unitOfWork.Users.GetAll();
            return users.ToList().Select(u => new UserViewModel
            {
                UserId = u.Id,
                Name = u.Name,
                Surname = u.Surname,
                Email = u.Email,
                Role = u.Role.ToString(),
                IsConfirmed = u.IsConfirmed
            });
        }

        public async Task<UserViewModel> GetUserByEmail(string email)
        {
            var user = await _unitOfWork.Users.GetByPredicate(u => u.Email == email);

            return user != null ? new UserViewModel
            {
                UserId = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Password = user.Password,
                Role = user.Role.ToString(),
                IsConfirmed = user.IsConfirmed
            } : null;
        }

        public async Task<Guid> GetUserIdByEmail(string email)
        {
            var user = await _unitOfWork.Users.GetByPredicate(u => u.Email == email);

            return user.Id;
        }

        public async Task<UserViewModel> GetUserById(Guid id)
        {
            var user = await _unitOfWork.Users.GetByPredicate(u => u.Id == id);

            return user != null ? new UserViewModel
            {
                UserId = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role.ToString(),
                IsConfirmed = user.IsConfirmed
            } : null;
        }

        public async Task<LoginViewModel> Login(LoginViewModel model)
        {
            if (!_unitOfWork.Users.Login(model.Email, model.Password))
                return new LoginViewModel { Message = "Неверное имя пользователя или пароль!" };
            var user = await _unitOfWork.Users.GetByPredicate(u => u.Email == model.Email);
            model.UserId = user.Id;
            return model;
        }

        public async Task<RegistrationViewModel> Registration(RegistrationViewModel model)
        {
            var us = await _unitOfWork.Users.GetByPredicate(u => u.Email == model.Email);
            if (us != null)
                return new RegistrationViewModel { Message = "Пользователь с таким именем уже существует!" };
            var user = _unitOfWork.Users
                .Registration(new User
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email,
                    Password = Crypto.Sha256(model.Password + model.Email),
                    Role = Enums.Role.User
                });

            var registeredUser = new RegistrationViewModel
            {
                UserId = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role,
                Message = null
            };
            return registeredUser;
        }

        public string GetRole(string email)
        {
            return _unitOfWork.Users.GetRole(email);
        }

        public async Task<bool> IsExists(string email)
        {
            var user = await _unitOfWork.Users.GetByPredicate(u => u.Email == email);
            return user != null;
        }

        public void ConfirmEmail(string email)
        {
            _unitOfWork.Users.ConfirmEmail(email);
        }

        public async Task<bool> IsConfirmed(string email)
        {
            var user = await _unitOfWork.Users.GetByPredicate(u => u.Email == email);
            return user != null ? user.IsConfirmed : false;
        }
    }
}
