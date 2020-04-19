using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SE.Model.ViewModels
{
    public class CommentViewModel
    {
        public Guid CommentId { get; set; }

        public string CommentDate { get; set; }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }

        public Guid MaterialId { get; set; }

        [Required(ErrorMessage = "Введите текст комментария")]
        public string CommentText { get; set; }
    }
}
