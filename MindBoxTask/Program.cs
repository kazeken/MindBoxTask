using MindBoxTask;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите фигуру: 1 - Круг, 2 - Треугольник");
        int choice = int.Parse(Console.ReadLine());

        Shape shape = null;

        switch (choice)
        {
            case 1:
                Console.Write("Введите радиус круга: ");
                double radius = double.Parse(Console.ReadLine());
                shape = new Circle(radius);
                break;
            case 2:
                Console.Write("Введите сторону A: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону B: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону C: ");
                double sideC = double.Parse(Console.ReadLine());
                shape = new Triangle(sideA, sideB, sideC);
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }

        Console.WriteLine($"Площадь фигуры: {shape.CalculateArea()}");

        if (shape is Triangle triangle)
        {
            Console.WriteLine($"Треугольник прямоугольный: {triangle.IsRightTriangle()}");
        }
    }
}
