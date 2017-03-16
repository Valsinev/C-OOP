using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses4
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivanRainov = new School("PTG Ivan Rainov");
            var bg = new Discipline("Bulgarian");
            bg.ExerciseCount = 5;
            bg.SubjectCount = 2;
            var disc = new Discipline("Math");
            var mathTeacher = new Teacher ("Pesho");

            mathTeacher.AddDiscipline(disc);
            var mathemathic = new SchoolClass("Mathemathics");
            mathemathic.AddTeacher(mathTeacher);
        }
    }
}
