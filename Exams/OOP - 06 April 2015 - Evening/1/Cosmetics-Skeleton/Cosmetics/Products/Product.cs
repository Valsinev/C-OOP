
namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    public abstract class Product : IProduct
    {
        private const int MaxNameLenght = 10;
        private const int MinNameLenght = 3;
        private const int MaxProductNameLenght = 10;
        private const int MinProductNameLenght = 2;
        private const string BrandAndNameOutput = "- {0} – {1}:";
        private const string PriceOutput = "  * Price: ${0}";
        private const string BGenderOutput = "  * For gender: {0}";


        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfStringLengthIsValid(value,
                    MaxNameLenght, MinNameLenght, 
                    string.Format(GlobalErrorMessages.InvalidStringLength,"Product name",MinNameLenght,MaxNameLenght));
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                Validator.CheckIfStringLengthIsValid(value,
                    MaxProductNameLenght, MinProductNameLenght, 
                    string.Format(GlobalErrorMessages.InvalidStringLength,"Product brand",MinProductNameLenght,MaxProductNameLenght));
                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set 
            {
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get { return this.gender; }
        }


        public virtual string Print()
        {
            var output = new StringBuilder();
            output.AppendLine(string.Format(BrandAndNameOutput,this.brand,this.name));
            output.AppendLine(string.Format(PriceOutput, this.price));
            output.AppendLine(string.Format(BGenderOutput, this.gender.ToString()));
            return output.ToString().Trim();
        }
    }
}
