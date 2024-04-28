using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольник__20_2__
{
    class Triangle <T>
    {
        /// <summary>
        /// Создание поля а
        /// </summary>
        private T a;
        /// <summary>
        /// Создание поля b
        /// </summary>
        private T b;
        /// <summary>
        /// Создание поля c
        /// </summary>
        private T c;
        /// <summary>
        /// Свойства А
        /// </summary>
        public T A { get; set; }
        /// <summary>
        /// Свойства В
        /// </summary>
        public T B { get; set; }
        /// <summary>
        /// Свойства С
        /// </summary>
        public T C { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(T a, T b, T c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        /// <summary>
        /// Метод для вывода площади треугольника 
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Сторона А: {A}\nСторона B: {B}\nСторона C: {C}");
        }
        public string Square(dynamic a, dynamic b, dynamic c)
        {
            if ((a + b) > c && (a + c) > b && (c + b) > a)
            {
                double per = a + b + c;
                double p = per / 2;
                return $"Треугольник существует.\nПлощадь: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}";
            }
            else
            {
                return "Треульник не существует";
            }
        }

    }
}
