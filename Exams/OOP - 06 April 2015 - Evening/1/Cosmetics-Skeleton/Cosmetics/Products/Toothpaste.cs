
namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private const int MaxIngredientLenght = 12;
        private const int MinIngredientLenght = 4;

        private IList<string> ingredients;
        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {

            this.ingredients = new List<string>(ingredients);
            ChechIngredients();
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); } 
        }

        private void ChechIngredients()
        {
            foreach (var ingredient in this.ingredients)
            {
                Validator.CheckIfStringLengthIsValid(
                    ingredient, MaxIngredientLenght,MinIngredientLenght , 
                    string.Format(GlobalErrorMessages.InvalidStringLength,this.GetType().Name,MinIngredientLenght,MaxIngredientLenght));
            }
        }
        public override string Print()
        {
            var output = new StringBuilder();

            output.AppendLine(base.Print());
            output.AppendLine(string.Format("  * Ingredients: {0}",this.Ingredients));

            return output.ToString().Trim();
        }
    }
}
