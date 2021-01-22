using System;

namespace MethodExercise
{
    class Program
    {
        /* these are being called as classes
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
        */
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

            var sum1 = MyAdd(1,2,3,4,5,6);
            var mult1 = MyMultiply(2, 4, 6);
            Console.WriteLine(sum1);
            Console.WriteLine(mult1);
        }
        //These are being called as methods
        public static int MyAdd(params int[] list)
        {
            int sum = 0;
            //for (int i = 0; i <=(list.Length-1); i++)
            foreach (int element in list)
            {
                sum = sum + element;
            }
            return sum;

        }
        public static int MyMultiply(params int[] list)
        {
            int sum = 1;
            for (int i = 0; i <= (list.Length - 1); i++)
            {
                sum = sum * list[i];
            }
            return sum;
        }
    }
}
