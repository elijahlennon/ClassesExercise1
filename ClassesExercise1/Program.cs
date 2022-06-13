using System;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var elijahsCar = new Car();

            elijahsCar.Make = "Hyudai";

            elijahsCar.Model = "Sonata Hybrid";

            elijahsCar.Year = 2014;

            Console.WriteLine($"Elijah drives {elijahsCar.Make}, {elijahsCar.Model}, {elijahsCar.Year}.");
        }
        

    }
}
