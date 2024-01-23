using System.Data.SqlTypes;
using System;

namespace Телефония
{
    public class Smartphone : ICallable, IBrowsable
    {
        public void Call(string number)
        {
            if (!IsValidNumber(number))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url)
        {
            if (!IsValidUrl(url))
            {
                Console.WriteLine("Invalid URL!");
                return;
            }

            Console.WriteLine($"Browsing: {url}!");
        }

        private bool IsValidNumber(string number)
        {
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidUrl(string url)
        {
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

    public interface ICallable
    {
        void Call(string number);
    }
    public interface IBrowsable
    {
        void Browse(string url);
    }
}