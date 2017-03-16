
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Class : ICommentable
    {
        public string Id { get; private set; }

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
    
        private List<Teacher> teachers;
        private List<Student> students;
        private List<string> comments = new List<string>();


        public Class (string name)
        {
            this.Id = name;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.teachers.Add(newTeacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }


        public void AddStudent(Student newStudent)
        {
            this.students.Add(newStudent);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public void AddComment(string newComment)
        {
            this.comments.Add(newComment);
        }
    }
}
