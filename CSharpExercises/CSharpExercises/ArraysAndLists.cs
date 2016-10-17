using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class ArraysAndLists
    {
        public static void ExerciseOne()
        {
            var nameList = new List<string>();

            while (true)
            {
                Console.Write("Enter a Name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    break;
                }

                nameList.Add(input);
            }

            if (nameList.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", nameList.First());
            }
            else if (nameList.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", nameList.ElementAt(0), nameList.ElementAt(1));
            }
            else if (nameList.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post.", nameList.ElementAt(0), nameList.ElementAt(1), nameList.Count - 2);
            }
        }

        public static void ExerciseTwo()
        {
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();
            var array = new char[input.Length];

            for (var i = input.Length; i > 0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }

            var reversedName = new string(array);

            Console.WriteLine(reversedName);
        }

        public static void ExerciseThree()
        {
            var numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                var numberInput = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(numberInput))
                {
                    Console.WriteLine("Your already entered this number.");
                    i--;
                    continue;
                }

                numbers[i] = numberInput;
            }

            Array.Sort(numbers);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void ExerciseFour()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (Quit to exit): ");
                var input = Console.ReadLine();

                if(input.Equals("Quit"))
                {
                    break;
                }

                var inputNumber = Convert.ToInt32(input);
                numbers.Add(inputNumber);
            }

            foreach (var number in numbers.Distinct())
            {
                Console.WriteLine(number);
            }
        }

        public static void ExerciseFive()
        {
            string[] numberArray;

            while (true)
            {
                Console.Write("Enter some numbers (Eg. 1, 2, 3, 4, 5): ");
                var inputNumbers = Console.ReadLine();

                numberArray = inputNumbers.Split(',');

                if (numberArray.Length < 5)
                {
                    Console.WriteLine("Try again.");
                    continue;
                }

                break;
            }

            Array.Sort(numberArray);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }
    }
}
