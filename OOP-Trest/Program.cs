using System;

namespace OOP_Trest
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            Console.WriteLine("You can buy");
            foreach (var TV in shop.TVs)
            {

                Console.WriteLine($"{TV.Brand}, {TV.Type}, {TV.Diagonal}");
            }
        }
    }
}
