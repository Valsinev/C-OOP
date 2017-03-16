
namespace GenericHomework
{
    using System;
    class Startup
    {
        static void Main()
        {
            Elements<int> test = new Elements<int>(6);
            test.AddElement(5);
            test.AddElement(10);
            test.AddElement(20);
            Console.WriteLine(test[3]);
        }
    }
}
