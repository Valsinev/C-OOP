using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    public static class StudentSystem
    {
        public static List<Student> students = new List<Student>();

        public static List<Student> AddStudent(Student newStudent)
        {
            students.Add(newStudent);
            return students;
        }
        public static List<Student> Students {get;set;}

        //Problem 3. First before last
        public static IEnumerable<Student> FirstBeforeLast(IEnumerable<Student> collection)
        {
            var sortedStudents = StudentSystem.students.Where(st => st.FirstName[0] < st.LastName[0]).ToArray();
            return sortedStudents;
        }
        
    }
}
