using System;
// Los ciclos FOR ejecutan una instrucci[on o varias, cada vez que ejecuta un ciclo
namespace forCicle
{
    class Program
    {
        static void Main(string[] args)
        {   
            for (int i=0 /*condicion inicial*/; i < 50 /* limite de repeticiones*/; i = i+ 10 /*Incremento*/)
            {
                Console.WriteLine("Hello World! #{0}", i);

            }
        }
    }
}
