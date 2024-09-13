using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTask
{
    public  class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                throw new ArgumentException("Стороны должны быть позитивными.");
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
                throw new ArgumentException("Стороны не формируют треугольник.");

            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightTriangle()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                throw new ArgumentException("Стороны должны быть позитивными.");
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
                throw new ArgumentException("Стороны не формируют треугольник.");

            return (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)) || (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2))||
                 (Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2));
        }
    }
}
