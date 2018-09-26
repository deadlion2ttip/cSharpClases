using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }

        public void Threaten()
        {
            Console.WriteLine("You Killed My Father, Prepare to Die");
        }

    }
}
