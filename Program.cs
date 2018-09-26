 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
