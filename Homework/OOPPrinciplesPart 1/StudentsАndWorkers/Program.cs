
namespace StudentsАndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho","Ganev","9A"),
                new Student("Ivan", "Penev", "8B"),
                new Student("Zlatka", "Petrova", "11E"),
                new Student("Daniela", "Stoyanova", "9A"),
                new Student("Stoyan", "Pavlov", "10Z"),
                new Student("Kolio", "Iordanov", "7A"),
                new Student("Petko", "Stamenov", "5V"),
                new Student("Valia", "Dimitrova", "5A"),
                new Student("Stanka", "Zlateva", "7G"),
                new Student("Irina", "Daskalova", "9B"),
            };

            var sortedByGrade = students.OrderBy(st => st.Grade);


            foreach (var item in sortedByGrade)
            {
                Console.WriteLine(item);
            }
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Atanas","Stefanov",200m,8),
                new Worker("Radka", "Radeva",180m,8),
                new Worker("Pavel", "Kostov", 280m,8),
                new Worker("Kosta", "Stoyanov",100m,5),
                new Worker("Daniel", "Vulev", 300m,12),
                new Worker("Marian", "Kalchev", 150m,7),
                new Worker("Stamen", "Zahariev", 80m,4),
                new Worker("Zornica", "Panaiotova",20m,2),
                new Worker("Kera", "Ivanova", 200m,7),
                new Worker("Tania", "Daskalova",214m,8),
            };
            Console.WriteLine();
            var workersByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour());

            foreach (var worker in workersByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }

        }

    }
}
