using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class StringsAndText
    {
        public static void ExerciseOne()
        {
            var isConsecutive = true;

            Console.Write("Enter a few numbers (Eg: 1-2-3-4): ");
            var numbersInput = Console.ReadLine();
            var numbers = new List<int>();
            
            foreach (var number in numbersInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i + 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        public static void ExerciseTwo()
        {
            var numbers = new List<int>();
            var originals = new List<int>();

            Console.Write("Enter a few numbers (Eg: 1-2-3-4): ");
            var numbersInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(numbersInput))
                return;

            foreach (var number in numbersInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            foreach (var number in originals)
            {
                if (originals.Contains(number))
                {
                    Console.WriteLine("Duplicates");
                    return;
                }

                originals.Add(number);
            }
        }

        public static void ExerciseThree()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void ExerciseFour()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }

        public static void ExerciseFive()
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
