
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public class Category : ICategory
    {
        private const int NameMaxLenght = 15;
        private const int NameMinLenght = 2;

        private string name;
        private ICollection<IProduct> cosmeticsAggregate;
        public Category(string name)
        {
            this.Name = name;
            this.cosmeticsAggregate = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CheckIfStringLengthIsValid(value,
                    NameMaxLenght, NameMinLenght ,
                    string.Format(GlobalErrorMessages.InvalidStringLength,"Category name",NameMinLenght,NameMaxLenght));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics,string.Format(GlobalErrorMessages.ObjectCannotBeNull, cosmetics));
            this.cosmeticsAggregate.Add(cosmetics);
            this.cosmeticsAggregate.OrderBy(c => c.Brand).ThenByDescending(c => c.Price);

        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
           //if (this.cosmeticsAggregate.Any(c => c == cosmetics))
           //{
            this.cosmeticsAggregate.Remove(cosmetics);
            this.cosmeticsAggregate.OrderBy(c => c.Brand).ThenByDescending(c => c.Price);
           //}
           //throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics, this.name));
            
        }

        public string Print()
        {
            this.cosmeticsAggregate.OrderBy(c => c.Brand).ThenByDescending(c => c.Price);

            var output = new StringBuilder();
            string ifPlural = this.cosmeticsAggregate.Count == 1 ? "product" : "products";

            output.AppendLine(string.Format("{0} category – {1} {2} in total",this.name,cosmeticsAggregate.Count,ifPlural));
            foreach (var cosmetic in this.cosmeticsAggregate)
            {
                output.AppendLine(cosmetic.Print().Trim());
            }
            return output.ToString().Trim();
        }
    }
}
