 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Math;

namespace ConsoleApp1
{  
    class Program
    {
        static void Main(string[] args)
        {
            Person Chris = new Person();
            Chris.FirstName = "Chris";
            Chris.LastName = "Griffin";

            Chris.Introduce();
            Chris.Threaten();

            Console.WriteLine(Calculator.Add(1, 5));
        }
    }
}
