using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsexercise1n2
{
    internal class exercise2
    {

        public static double AreaOfCircle(double radius)
        {
            Console.WriteLine("Please Write the radius of your circle");
            radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow (radius, 2);
            return area;
            
        }

    }
}
