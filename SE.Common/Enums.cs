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
            [Display(Name = "Презентации, викторины")]
            Presentation,
            [Display(Name = "Иллюстрации")]
            Illustrations,
            [Display(Name = "Конспекты")]
            Summaries,
            [Display(Name = "Информация для родителей")]
            ParentsInfo
        }

        public enum MaterialStatus
        {
            [Display(Name = "Все")]
            All = 0,
            [Display(Name = "На модерации")]
            OnModeration,
            [Display(Name = "Опубликованно")]
            Published,
            [Display(Name = "Удалено")]
            Deleted
        }

        public enum Theme
        {
            [Display(Name = "Общее")]
            Common = 0,
            [Display(Name = "Пожарная безопасность")]
            FireSafety,
            [Display(Name = "Безопасность в быту")]
            SafetyAtHome,
            [Display(Name = "ПДД")]
            TrafficRules,
            [Display(Name = "Человек и природа")]
            HumanAndNature,
            [Display(Name = "Ребенок и общество")]
            ChildAndSociety,
            [Display(Name = "Моя родина")]
            MyCountry
        }

        public enum SortType
        {
            [Display(Name = "по алфавиту (от А до Я)")]
            AlphabetAsc = 0,
            [Display(Name = "по алфавиту (от Я до А)")]
            AlphabetDesc,
            [Display(Name = "по дате (сначала новые)")]
            DateAsc,
            [Display(Name = "по дате (сначала старые)")]
            DateDesc
        }
    }
}
