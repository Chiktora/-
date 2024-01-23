using System;

namespace Телефония
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone phone = new Smartphone();

            foreach (var number in numbers)
            {
                phone.Call(number);
            }

            foreach (var url in urls)
            {
                phone.Browse(url);
            }
        }
    }
}
