using System;
using System.Collections.Generic;
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
            Common = 0,
            Teachers,
            Parents
        }

        public enum Type
        {
            Common = 0,
            Video,
            Presentation,
            Quizzes,
            Illustrations,
            Summaries,
            Articles,
            Consultations,
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
