
namespace DefineClass
{
    using System;

    class Startup
    {
        static void Main()
        {
            GSM Nokia = new GSM("Lumia", "Nokia");
            Nokia.Price = 456.32m;
            Nokia.Owner = "Pesho";
            Console.WriteLine(Nokia);
        }
    }
}
