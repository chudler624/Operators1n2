using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsexercise1n2
{
    internal class Methods
    {

        public static int Add(int a, int b)
        {
            return (a + b);

        }

        public static int Subtract(int a, int b)
        {
            return (a - b);
        }

        public static int Multiply(int a, int b)
        {
            return (a * b);
        }

        public static int Divide(int a, int b)
        {
            return (a / b);
        }

        public static int Modulus(int a, int b)
        {
            return (a % b);


        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("Write the radius");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }

}
