

namespace SoftwareAcademy
{
    using System.Text;
    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                Validator.StringValidator(value, "Town cannot be null or empty !");
                this.town = value;
            }
        }
        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            result.AppendFormat("; Town={0}", this.town);

            return result.ToString().Trim();
        }
    }
}
