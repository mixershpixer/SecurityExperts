﻿using System;
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
            Educators,
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
            [Display(Name = "Опубликовано")]
            Published,
            [Display(Name = "Удалено")]
            Deleted
        }

        public enum Theme
        {
            [Display(Name = "Общее")]
            Common = 0,
            [Display(Name = "Моя родина")]
            MyCountry,
            [Display(Name = "Безопасность в быту")]
            SafetyAtHome,
            [Display(Name = "Пожарная безопасность")]
            FireSafety,
            [Display(Name = "ПДД")]
            TrafficRules,
            [Display(Name = "Ребенок и общество")]
            ChildAndSociety,
            [Display(Name = "Человек и природа")]
            HumanAndNature
        }

        public enum SortType
        {
            [Display(Name = "по алфавиту (от А до Я)")]
            AlphabetAsc = 0,
            [Display(Name = "по алфавиту (от Я до А)")]
            AlphabetDesc,
            [Display(Name = "по дате (сначала старые)")]
            DateAsc,
            [Display(Name = "по дате (сначала новые)")]
            DateDesc,
            [Display(Name = "по популярности")]
            RateAsc
        }
    }
}
