using System;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Platzi!");

            int height = 170;
            int age = 20;
            string name = "Ricardo Celis";
            string information = "the requested info is: \n User name " + name + "\n user age "
                + age + " \n user height " + height;
            Console.WriteLine(information);


        }
    }
}
