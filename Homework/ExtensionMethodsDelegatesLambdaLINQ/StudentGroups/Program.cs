using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class Program
    {
        static void Main(string[] args)
        {
        #region List
            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Traichov",
                    FN = 8600,
                    Tel="0895867135",
                    Email = "blabla@abv.bg",
                    GroupNumber = 5,
                    Marks = new List<int>{3,5,6,2,3,4}
                },
                new Student
                {
                    FirstName = "Andrei",
                    LastName = "Stoyanov",
                    FN = 2531,
                    Tel="0898795700",
                    Email = "prbdnq@abv.bg",
                    GroupNumber = 6,
                    Marks = new List<int>{3,2,5,5,6,4}
                },
                new Student
                {
                    FirstName = "Petur",
                    LastName = "Ignatov",
                    FN = 1860,
                    Tel="0898900241",
                    Email = "grabo@abv.bg",
                    GroupNumber = 2,
                    Marks = new List<int>{6,4,6,5,6,6}
                },
                new Student
                {
                    FirstName = "Zdravko",
                    LastName = "Georgiev",
                    FN = 8690,
                    Tel="0898795722",
                    Email = "kokoshka@abv.bg",
                    GroupNumber = 1,
                    Marks = new List<int>{3,2,5,5,6,4}
                },
                new Student
                {
                    FirstName = "Nevena",
                    LastName = "Peneva",
                    FN = 8262,
                    Tel="0898991700",
                    Email = "nevencheto@abv.bg",
                    GroupNumber = 3,
                    Marks = new List<int>{6,6,5,6,6,6}
                },
                new Student
                {
                    FirstName = "Zlatka",
                    LastName = "Petrova",
                    FN = 1160,
                    Tel="0898795701",
                    Email = "kote@abv.bg",
                    GroupNumber = 4,
                    Marks = new List<int>{6,6,6,6,6,6}
                },
            #endregion
            };
           //var onlyGroup2 = students.Where(st => st.GroupNumber == 2);
           //foreach (var student in onlyGroup2)
           //{
           //    Console.WriteLine(student);
           //}
           //var sortByFirstName = students.OrderBy(st => st.FirstName);
           //foreach (var item in sortByFirstName)
           //{
           //    Console.WriteLine(item);
           //}
        }
    }
}
