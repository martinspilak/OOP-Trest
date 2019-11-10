using System;

namespace OOP_Trest
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            Console.WriteLine("You can buy this TVs");
            foreach (var TV in shop.TVs)
            {

                Console.WriteLine($"{TV.Brand}, {TV.Type}, {TV.Diagonal}");
            }
            var shop2 = new Shop();
            Console.WriteLine();
            Console.WriteLine("Or you can buy this Phones");
            foreach (var Phone in shop.Phones)
            {

                Console.WriteLine($"{Phone.Brand}, {Phone.Type}");
            }
        }
    }
}
