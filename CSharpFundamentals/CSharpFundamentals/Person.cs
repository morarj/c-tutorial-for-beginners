using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine(string.Format("My name is {0} {1}", firstName, lastName));
        }
    }
}
