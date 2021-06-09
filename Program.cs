using System;

namespace DoubleConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que captura una letra y te dice si es la letra A mayúscula o no");
            Console.WriteLine("Coloque una letra: ");
            var letter = Console.ReadLine();
            if (letter == "A")
            {
                Console.WriteLine("La letra es una A mayúscula!!");
            }
            else
            {
                Console.WriteLine("La letra no es una A mayúscula :c");
            }
        }
    }
}
