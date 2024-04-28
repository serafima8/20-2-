using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольник__20_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> triangle = new Triangle<int>();
            Console.WriteLine(triangle.Square(5, 6, 7));
            Triangle<double> triangle1 = new Triangle<double>();
            Console.WriteLine(triangle.Square(6.6, 4.3, 3.5));
            Triangle<uint> triangle2 = new Triangle<uint>();
            Console.WriteLine(triangle2.Square(200,267,120));

            Console.ReadKey();
        }
    }
}
