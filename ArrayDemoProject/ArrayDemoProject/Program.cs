using System;

namespace ArrayDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] coffeTypes;
            float[] coffePrices;

            coffeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" }; //4
            coffePrices = new float[] { 1.2f,        1.5f,     5.0f,      5.5f };

            coffeTypes[1] = "Lungo";
            for (int i = 0; i < 4; i++)
                Console.WriteLine(coffeTypes[i] + "Coffe $" + coffePrices[i]);

        }
    }
}
