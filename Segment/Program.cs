using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment<int> segment = new Segment<int>(5, 8, 2, 9);
            segment.Print();
            Console.WriteLine($"Длина отрезка: {segment.Length()}");
            Segment<long> segment1 = new Segment<long>(4, 1, 7, 3);
            segment1.Print();
            Console.WriteLine($"Длина отрезка: {segment1.Length()}");
            Segment<double> segment2 = new Segment<double>(5.5, 8.2, 2.9, 9.6);
            segment2.Print();
            Console.WriteLine($"Длина отрезка: {segment2.Length()}");
            Console.ReadKey();
        }
    }
}
