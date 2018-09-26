 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Math;

namespace ConsoleApp1
{  
    public enum ShippingMethod
    {
        AirMail = 1,
        RegisteredMail = 2,
        ExpressMail = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.ExpressMail;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            string methodName = "ExpressMail";
            Console.WriteLine((ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName));
        }
    }
}
