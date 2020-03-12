using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string firstNumber;
            string secondNumber;
            Console.WriteLine("Hello user");
       
            do
            {
                int integer;
                Console.WriteLine("Introduce the first number: ");
                firstNumber = Console.ReadLine();
                valid = int.TryParse(firstNumber, out integer);
                if (!valid)
                {
                    Console.WriteLine("ERROR: You need to introduce a number");
                }
            } while (!valid);
            Console.WriteLine("First number was added");
            do
            {
                int integer;
                Console.WriteLine("Introduce the second number: ");
                secondNumber = Console.ReadLine();
                valid = int.TryParse(secondNumber, out integer);
                if (!valid)
                {
                    Console.WriteLine("ERROR: You need to introduce a number");
                }

            } while (!valid);
            Console.WriteLine("Second number was added");

            var firstNumberInt = Int32.Parse(firstNumber);
            var secondNumberInt = Int32.Parse(secondNumber);

            var sum = firstNumberInt + secondNumberInt;
            var firstDifference = firstNumberInt - secondNumberInt;
            var secondDifference = secondNumberInt - firstNumberInt;

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The first diff is: {firstDifference}");
            Console.WriteLine($"The second diff is: {secondDifference}");

        }
    }
}
