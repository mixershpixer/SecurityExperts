using Microsoft.AspNetCore.Http;
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
        public string AuthorEmail { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }


        [Required(ErrorMessage = "Введите описание материала")]
        [StringLength(500, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string Description { get; set; }


        [Required]
        public Enums.MaterialStatus Status { get; set; }
        public string StatusString { get; set; }


        [Required]
        public DateTime PublishingDate { get; set; }
        public string PublishingDateString { get; set; }


        [Required(ErrorMessage = "Выберите целевую аудиторию")]
        public Enums.Auditory Auditory { get; set; }


        [Required(ErrorMessage = "Введите тему материала")]
        public Enums.Theme Theme { get; set; }
        public string ThemeString { get; set; }


        [Required]
        public Enums.Type Type { get; set; }
        public string TypeString { get; set; }

        [Required(ErrorMessage = "Укажите ссылку для скачивания")]
        [StringLength(500, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string DownloadingLink { get; set; }


        [Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Picture { get; set; }
        public byte[] BytePicture { get; set; }
        public string Base64Picture { get; set; }


        [Required(ErrorMessage = "Укажите источник информации")]
        [StringLength(500, ErrorMessage = "Количество символов не должно превышать {0} символов в длину.")]
        public string SourceOfInformation { get; set; }


        [Required]
        public double Rating { get; set; }


        [Required]
        public int DownloadsCount { get; set; }
    }
}
