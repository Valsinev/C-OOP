
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        private string model;

        private string manifacturer;

        private decimal price;

        private static GSM iPhone4s = new GSM("IPhone4S", "Apple");
        private List<Call> callHistory;
        

        public GSM(string phoneModel)
        {
            this.Model = phoneModel;
            this.Owner = null;
            this.Price = 0.0m;
            this.callHistory = new List<Call>();
        }
        public GSM(string phoneModel, string phoneManifacturer) : this(phoneModel)
        {
            this.manifacturer = phoneManifacturer;
            
        }
        public static GSM IPhone4S
        {
            get { return iPhone4s; }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Not typed model!");
                }
                this.model = value;
            }
        }
        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Not typed manifacturer!");
                }
                this.manifacturer = value;
            }
        }
        public decimal Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be bigger than 0");
                }
                this.price = value;
            }
        }
        public string Owner { get; set; }
        public override string ToString()
        {
            return this.Manifacturer + "\n" +
                   this.Model + "\n" + 
                   this.Owner + "\n" +
                   this.Price;
        }
    }
    
}
