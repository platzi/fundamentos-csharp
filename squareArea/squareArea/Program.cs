using System;

namespace squareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //rectangle area cal.
            Console.WriteLine("Please enter the side A of the rectangle, you can use decimals");
            float sideA = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the side B of the rectangle, you can use decimals");
            float sideB = float.Parse(Console.ReadLine());
            //rectangle values


            // rectangle area formula is a*b
            float area = sideA * sideB;
            
       
            Console.WriteLine(" The rectangle area is: " + area);

        }
    }
}
