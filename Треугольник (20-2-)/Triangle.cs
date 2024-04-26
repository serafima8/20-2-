using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольник__20_2__
{
    class Triangle <T>
    {
        private T a;
        private T b;
        private T c;

        public T A { get; set; }
        public T B { get; set; }
        public T C { get; set; }
        public Triangle() { }
        public Triangle(T a, T b, T c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void Show()
        {
            Console.WriteLine($"Сторона А: {A}\nСторона B: {B}\nСторона C: {C}");
        }
        public double Square(double a, double b, double c)
        {
            double per = a + b + c;
            double p = per/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
