using System;

namespace MethodExercise
{
    class Program
    {
        static void int Add(int num1, int num2)
        {
            int num = num1 + num2;
        }
        static void int Multiply(int num1, int num2)
        {
            int num = num1 * num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, tell me you name?:");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?:");
            var color = Console.ReadLine();
            Console.WriteLine("What animal do you like best?:");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?:");
            var band = Console.ReadLine();

            Console.WriteLine($"So your name is {name} and your favorite color is {color}. +" +
                $"Strangely, you like this animal: {animal}. That's all great, but {band} sucks.");

        }
    }
}
