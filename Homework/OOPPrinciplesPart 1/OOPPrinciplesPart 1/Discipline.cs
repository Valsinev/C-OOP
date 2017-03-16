

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Discipline : ICommentable
    {
        private string name;
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }
        private List<string> comments = new List<string>();

        public Discipline(string Name,int Lectures = 0 ,int Excercises = 0)
        {
            this.name = Name;
            this.NumberOfLectures = Lectures;
            this.NumberOfExercises = Excercises;
        }

        public void AddComment(string newComment)
        {
            this.comments.Add(newComment);
        }

        public ICommentable ICommentable
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
