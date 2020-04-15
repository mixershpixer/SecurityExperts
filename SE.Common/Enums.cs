using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SE.Common
{
    public class Enums
    {
        public enum Role
        {
            Admin = 0,
            User
        }

        public enum Auditory
        {
            [Display(Name = "Общее")]
            Common = 0,
            [Display(Name = "Воспитатели")]
            Teachers,
            [Display(Name = "Родители")]
            Parents
        }

        public enum Type
        {
            [Display(Name = "Общее")]
            Common = 0,
            [Display(Name = "Видео")]
            Video,
            [Display(Name = "Презентации")]
            Presentation,
            [Display(Name = "Викторины")]
            Quizzes,
            [Display(Name = "Иллюстрации")]
            Illustrations,
            [Display(Name = "Конспекты")]
            Summaries,
            [Display(Name = "Статьи")]
            Articles,
            [Display(Name = "Консультации")]
            Consultations,
            [Display(Name = "Памятки")]
            Memos
        }

        public enum MaterialStatus
        {
            Deleted = 0,
            OnModeration,
            Published,
            Rejected
        }
    }
}
