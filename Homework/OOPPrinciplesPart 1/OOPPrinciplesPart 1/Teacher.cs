
using System.Collections.Generic;
namespace SchoolClasses
{
    public class Teacher : People, ICommentable
    {
        private List<Discipline> disciplines;
        private List<string> comments = new List<string>();
        public Teacher(string firstName, string middleName,string lastName, List<Discipline> Disciplines = null)
            : base(firstName,middleName,lastName)
        {
            this.disciplines = Disciplines;
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
    
        public void AddDiscipline(Discipline newDiscipline)
        {
            this.disciplines.Add(newDiscipline);
        }
        

        public void AddComment(string newComment)
        {
            this.comments.Add(newComment);
        }  
    }
}
