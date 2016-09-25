using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            int i;

            // Implicit
            b = 1;
            i = b;
            Console.WriteLine(i);

            // Explicit
            i = 1;
            b = (byte) i;
            Console.WriteLine(b);

            i = 1000;
            b = (byte)i;
            Console.WriteLine(b);

            string str = "1234";
            i = Convert.ToInt32(str);
            Console.WriteLine(i);

            try
            {
                b = Convert.ToByte(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            try
            {
                str = "true";
                bool boolean = Convert.ToBoolean(str);
                Console.WriteLine(boolean);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
