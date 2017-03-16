
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Student : People, ICommentable
    {
        private List<string> comments = new List<string>();
        public Student(string firstName,string middleName,string lastName)
            :base(firstName,middleName,lastName)
        {
        }
        public Student(string firstName, string middleName, string lastName,int classNumber)
            : base(firstName, middleName, lastName)
        {
            this.ClassNumber = classNumber;
        }
        public int ClassNumber { get;private set; }

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

        public void AddComment(string newComment)
        {
            this.comments.Add(newComment);
        }
    }
}
