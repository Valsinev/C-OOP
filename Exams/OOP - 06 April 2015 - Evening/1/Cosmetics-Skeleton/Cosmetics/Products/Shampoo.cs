
namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    public class Shampoo : Product, IProduct, IShampoo
    {
        private const string QuantityOutput = "  * Quantity: {0} ml ";
        private const string UsageOutput = "  * Usage: {0}";

        private uint shampooMilliliters;
        private UsageType usageType;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand,price, gender)
        {
            this.shampooMilliliters = milliliters;
            this.usageType = usage;
            this.Price *= this.shampooMilliliters;
        }

        public uint Milliliters
        {
            get { return this.shampooMilliliters; }
        }

        public UsageType Usage
        {
            get { return this.usageType; }
        }
        public override string Print()
        {
            var output = new StringBuilder();

            output.AppendLine(base.Print());
            output.AppendLine(string.Format(QuantityOutput, this.shampooMilliliters));
            output.AppendLine(string.Format(UsageOutput,this.usageType.ToString()));

            return output.ToString().Trim();
        }
    }
}
