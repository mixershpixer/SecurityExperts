﻿using Microsoft.AspNetCore.Http;
using SE.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SE.Model.ViewModels
{
    public class MaterialViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Введите название материала")]
        [StringLength(50, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string Name { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Введите описание материала")]
        [StringLength(500, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string Description { get; set; }

        [Required]
        public Enums.MaterialStatus Status { get; set; }

        [Required]
        public DateTime PublishingDate { get; set; }

        [Required(ErrorMessage = "Выберите целевую аудиторию")]
        public Enums.Auditory Auditory { get; set; }

        [Required(ErrorMessage = "Введите тему материала")]
        [StringLength(100, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string Theme { get; set; }

        [Required]
        public Enums.Type Type { get; set; }

        [Required(ErrorMessage = "Укажите ссылку для скачивания")]
        [StringLength(500, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string DownloadingLink { get; set; }

        [Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = "Укажите источник информации")]
        [StringLength(500, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string SourceOfInformation { get; set; }

        [Required]
        public double Rating { get; set; }

        [Required]
        public int DownloadsCount { get; set; }
    }
}
