using System;

namespace CSharpExercises
{
    class Conditionals
    {
        // Write a program and ask the user to enter a number.
        // The number should be between 1 to 10. If the user enters a valid number, 
        // display "Valid" on the console.Otherwise, display "Invalid". 
        public static void ValidateNumber()
        {
            Console.Write("Enter a number from 1 - 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        // Write a program which takes two numbers from the console 
        // and displays the maximum of the two.
        public static void GreaterNumber()
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            Console.Write("Enter another number: ");
            input = Console.ReadLine();
            var number2 = Convert.ToInt32(input);

            if (number > number2)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }

        // Write a program and ask the user to enter the width and 
        // height of an image.Then tell if the image is landscape or 
        // portrait.
        public static void Image()
        {
            Console.Write("Width: ");
            var input = Console.ReadLine();
            var width = Convert.ToInt32(input);

            Console.Write("Height: ");
            input = Console.ReadLine();
            var height = Convert.ToInt32(input);

            var orientation = (width > height) ? Orientation.Landscape : Orientation.Portrait;

            Console.WriteLine(orientation);
        }

        // Your job is to write a program for a speed camera. 
        // For simplicity, ignore the details such as camera, sensors, etc 
        // and focus purely on the logic. Write a program that asks the user 
        // to enter the speed limit. Once set, the program asks for the speed 
        // of a car. If the user enters a value less than the speed limit, 
        // program should display Ok on the console. If the value is above the 
        // speed limit, the program should calculate the number of demerit 
        // points. For every 5km/hr above the speed limit, 1 demerit points 
        // should be incurred and displayed on the console. If the number of 
        // demerit points is above 12, the program should display License Suspended.
        public static void SpeedCamera()
        {
            const int _kmDemeritPoint = 5;

            Console.Write("Speed Limit: ");
            var input = Console.ReadLine();
            var speedLimit = Convert.ToInt32(input);

            Console.Write("Car speed: ");
            input = Console.ReadLine();
            var carSpeed = Convert.ToInt32(input);

            if (speedLimit >= carSpeed)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var kmOverSpeedLimit = carSpeed - speedLimit;
                var demeritPoints = kmOverSpeedLimit / _kmDemeritPoint;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                }
            }
        }

        public enum Orientation
        {
            Landscape,
            Portrait
        }
    }
}
