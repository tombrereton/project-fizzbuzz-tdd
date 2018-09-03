using System;
using FizzBuzzCalculator;

namespace FizzBuzzRunner
{
    class FizzBuzzProgram
    {
        static void Main()
        {
            for (int i = 1; i < 101; i++)
            {
                var fizzBuzzed = FizzBuzz.Convert(i);
                Console.WriteLine(i + ": " +fizzBuzzed);
            }
            Console.ReadKey();
        }
    }
}
