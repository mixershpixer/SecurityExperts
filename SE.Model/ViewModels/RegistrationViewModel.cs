﻿using SE.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SE.Model.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public Guid UserId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Введите Имя")]
        [StringLength(20, ErrorMessage = "Максимальная длина Имени 15 символов")]
        [RegularExpression(@"^[A-Za-zА-Яа-я0-9 ]+$", ErrorMessage = "Некорректное Имя")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Введите Фамилию")]
        [StringLength(20, ErrorMessage = "Максимальная длина Фамилии 15 символов")]
        [RegularExpression(@"^[A-Za-zА-Яа-я0-9 ]+$", ErrorMessage = "Некорректная Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Некорректный Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [StringLength(256, ErrorMessage = "Пароль должен быть минимум {2} символов", MinimumLength = 6)]
        [Required(ErrorMessage = "Введите Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        public Enums.Role Role { get; set; }

        public string Message { get; set; }
    }
}
