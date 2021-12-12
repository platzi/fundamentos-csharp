using System;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please Write your full name");
            string fullUserName = Console.ReadLine();

            Console.WriteLine("hello " + fullUserName + ", Welcome to Platzi");
        }
    }
}
