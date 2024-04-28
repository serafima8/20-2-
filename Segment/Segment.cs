using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment
{
    class Segment <T>
    {
        /// <summary>
        /// Создание поля х1
        /// </summary>
        private T x1;
        /// <summary>
        /// Создание поля у1
        /// </summary>
        private T y1;
        /// <summary>
        /// Создание поля х2
        /// </summary>
        private T x2;
        /// <summary>
        /// Создание поля у2
        /// </summary>
        private T y2;
        /// <summary>
        /// Свойства х1
        /// </summary>
        public T X1 { get; set; }
        /// <summary>
        /// Свойства у1
        /// </summary>
        public T Y1 { get; set; }
        /// <summary>
        /// Свойства х2
        /// </summary>
        public T X2 { get; set; }
        /// <summary>
        /// Свойства у2
        /// </summary>
        public T Y2 { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Segment() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }
        /// <summary>
        /// Метод для вывода информации точек отрезка
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Точки отрезка: {X1};{Y1} и {X2};{Y2}");
        }
        /// <summary>
        /// метод для вывода информации о длине отрезка
        /// </summary>
        /// <returns></returns>
        public double Length()
        {
            dynamic dx = Convert.ToDouble(this.X2) - Convert.ToDouble(this.X1);
            dynamic dy = Convert.ToDouble(this.Y2) - Convert.ToDouble(this.Y1); 

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }
    }
}
