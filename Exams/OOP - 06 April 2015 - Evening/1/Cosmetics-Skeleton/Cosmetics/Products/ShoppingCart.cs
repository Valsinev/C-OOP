
namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public class ShoppingCart : IShoppingCart
    {
        private decimal totalPrice;
        private ICollection<IProduct> purchases;
        public ShoppingCart()
        {
            this.purchases = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product,string.Format(GlobalErrorMessages.ObjectCannotBeNull,"Product"));
            this.purchases.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.purchases.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.purchases.Any(p => p == product);
        }

        public decimal TotalPrice()
        {
            foreach (var purchase in this.purchases)
            {
                this.totalPrice += purchase.Price;
            }
            return this.totalPrice;
        }
    }
}
