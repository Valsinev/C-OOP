
namespace DefineClasses4
{
    class Discipline
    {
        private string name;
        private int subjectCount;
        private int exerciseCount;

        public Discipline(string discName)
        {
            this.name = discName;
            this.SubjectCount = 0;
            this.exerciseCount = 0;
        }
        public int SubjectCount
        {
            get
            {
                return this.subjectCount;
            } 
            set
            {
                if (value >= 0)
                {
                    this.subjectCount = value;
                }
                else
                {
                    this.subjectCount = 0;
                }
            }
        }
        public int ExerciseCount
        {
            get
            {
                return this.exerciseCount;
            }
            set
            {
                if (value >= 0)
                {
                    this.exerciseCount = value;
                }
                else
                {
                    this.exerciseCount = 0;
                }
            }
        }
    }
}
