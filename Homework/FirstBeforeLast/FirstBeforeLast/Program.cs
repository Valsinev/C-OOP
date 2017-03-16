
namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            

            Student s1 = new Student("Petur", "Ganev",25);
            Student s2 = new Student("Toncho", "Mihaylov",20);
            Student s3 = new Student("Kolio", "Nikolov",24);
            Student s4 = new Student("Mitko", "Zaykov",19);
            Student s5 = new Student("Venislav", "Stoyanov",26);

            StudentSystem.AddStudent(s1);
            StudentSystem.AddStudent(s2);
            StudentSystem.AddStudent(s3);
            StudentSystem.AddStudent(s4);
            StudentSystem.AddStudent(s5);

            var sorted = StudentSystem.FirstBeforeLast(StudentSystem.students);
            sorted.ForEach(Console.WriteLine);
            //Problem 4. Age range
            var sortByAge = StudentSystem.students.Where(st => st.Age >= 18 && st.Age <= 24).ToArray();
            sortByAge.ForEach(Console.WriteLine);
            Console.WriteLine();
            //Problem 5. Order students
            var orderBy = StudentSystem.students.OrderByDescending(st => st.FirstName).ThenBy(st => st.LastName);
            orderBy.ForEach(Console.WriteLine);
        }
    }
}
