using System;
using System.ComponentModel.DataAnnotations;

namespace SE.Model.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Некорректный Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Message { get; set; }

        public bool IsConfirmed { get; set; }
    }
}
