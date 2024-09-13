using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTask
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            if (Radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом!");

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
