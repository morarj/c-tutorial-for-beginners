using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    // Demo: Enums
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
        // Demo: Classes
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

        // Demo: Arrays
            //int[] numbers = new int[3];
            var numbers = new int[3];
            numbers[0] = 1;

            var flags = new bool[3];
            flags[0] = true;

            var names = new string[3] { "John", "Jack", "James" };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

        // Demo: Strings
            // string firstName = "Hugo";
            // String lastName = "Morales"; Needs the import of the namespace System
            var firstName = "Hugo";
            var lastName = "Morales";
            var fullName = string.Format("{0} {1}", firstName, lastName);


            var listOfNames = string.Join(",", names);
            Console.WriteLine(listOfNames);

            // Verbatim strings
            var text = "Hi \n Look into these\n c:\\folder\\folder\\folder\\file";
            Console.WriteLine(text);
            text = @"Hi
Look into these
c:\folder\folder\folder\file";

        // Demo: Enums
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            // Parsing: Converting a string to another type
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        // Demo: Reference Types &  Value Types
            // Value Types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}"), a, b);

            // Reference Types
            var array1 = new int[3] { 1,2,3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            // Value type - No change because the value is coppied to the method scope
            Increment(a);
            Console.WriteLine(a);

            // Reference Value - Changes because of the reference to the same spot on memory
            john.Age = 25;
            MakeOld(john);
            Console.WriteLine(john.Age);
        }

        public static void Increment(int number)
        {
            number += 20;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
