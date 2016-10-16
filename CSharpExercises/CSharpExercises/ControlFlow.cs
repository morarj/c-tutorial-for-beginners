using System;

namespace CSharpExercises
{
    class ControlFlow
    {
        public static void ExerciseOne()
        {
            byte counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }

            Console.WriteLine("Number divisible by 3 with no remainder: " + counter);
        }

        public static void ExerciseTwo()
        {
            int counter = 0;
            var input = "";
            int number;

            while (true)
            {
                Console.Write("Enter a number or \'ok\' to exit: ");
                input = Console.ReadLine();

                if(input.Equals("ok"))
                {
                    break;
                }

                number = Convert.ToInt32(input);
                counter += number;
            }

            Console.WriteLine("The sum of all the numbers you entered is: " + counter);
        }

        public static void ExerciseThree()
        {
            Console.Write("Enter a number: ");

            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            var factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial is: {0}", factorial);
        }

        public static void ExerciseFour()
        {
            const int numberOfTries = 4;
            var random = new Random();
            var randomNumber = random.Next(1, 10);

            for (int i = 0; i < numberOfTries; i++)
            {
                Console.Write("Enter a number: ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());

                if(inputNumber == randomNumber)
                {
                    Console.WriteLine("You Won!");
                    return;
                }
            }

            Console.WriteLine("You Lost!");
        } 

        public static void ExerciseFive()
        {
            Console.Write("Enter a series of numbers (Eg: 1,2,3,4): ");

            var numbersInput = Console.ReadLine();
            var numbersArray = numbersInput.Split(',');

            var max = Convert.ToInt32(numbersArray[0]);

            foreach (var strNum in numbersArray)
            {
                var number = Convert.ToInt32(strNum);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max number is: " + max);
        }
    }
}
