using System;

namespace MethodExercise
{
    class Program
    {
        static void MyAdd(params int[] list)
        {
            int sum = 0;
            //for (int i = 0; i <=(list.Length-1); i++)
            foreach (int element in list)
            {
                sum = sum + element;
            }
            Console.WriteLine(sum);
            
        }
        static void MyMultiply(params int[] list)
        {
            int sum = 1;
            for (int i = 0; i <= (list.Length - 1); i++)
            {
                sum = sum * list[i];
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome, tell me you name?:");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?:");
            var color = Console.ReadLine();
            Console.WriteLine("What animal do you like best?:");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?:");
            var band = Console.ReadLine();

            Console.WriteLine($"So your name is {name} and your favorite color is {color}. +" +
                $"Strangely, you like this animal: {animal}. That's all great, but {band} sucks.");
            */

            MyAdd(1,2,3,4,5,6);
            MyMultiply(2, 4, 6);
        }
    }
}
