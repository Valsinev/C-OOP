

namespace SoftwareAcademy
{
    using System.Text;
    public class LocalCourse : Course, ICourse, ILocalCourse
    {
        private string lab;
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                //Validator.StringValidator(value);
                this.lab = value;
            }
        }
        public override string ToString()
        {
            var output = new StringBuilder(base.ToString());

            output.AppendFormat("; Lab={0}", this.lab);

            return output.ToString().Trim();
        }
    }
}
