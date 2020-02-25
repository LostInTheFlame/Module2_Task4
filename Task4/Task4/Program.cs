using System;

namespace Task4
{
    class Program
    {
        static string shapeSelection;

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру для которой будет рассчитана площадь или периметр (введите одну из цифр, указанных ниже):");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Четырехугольник");
            Console.WriteLine("3. Круг\n\n");
            shapeSelection = Console.ReadLine();

            switch (shapeSelection)
            {
                case "1":
                    Console.WriteLine("Вы выбрали треугольник.");
                    methodSelection();
                    break;
                case "2":
                    Console.WriteLine("Вы выбрали четырехугольник.");
                    methodSelection();
                    break;
                case "3":
                    Console.WriteLine("Вы выбрали круг.");
                    methodSelection();
                    break;
                default:
                    Console.WriteLine("Вы сделали неправильный выбор.");
                    break;
            }
            Console.ReadKey(true);
        }

        static void methodSelection()
        {
            Console.WriteLine("\n\nВыберите что будет рассчитано (введите одну из цифр, указанных ниже:");
            Console.WriteLine("1. Площадь");
            Console.WriteLine("2. Периметр\n\n");
            string method = Console.ReadLine();

            switch (method)
            {
                case "1":
                    Console.WriteLine("Вы выбрали расчет площади.\n\n");
                    area();
                    break;
                case "2":
                    Console.WriteLine("Вы выбрали расчет периметра.\n\n");
                    perimeter();
                    break;
                default:
                    Console.WriteLine("Вы сделали неправильный выбор. ");
                    break;
            }
        }

        static void area()
        {
            double S;
            switch (shapeSelection)
            {
                case "1":
                    Console.WriteLine("Введите высоту и длину основания треугольника: ");

                    if (double.TryParse(Console.ReadLine(), out double height) && double.TryParse(Console.ReadLine(), out double baseLength) && height > 0 && baseLength > 0)
                    {
                        S = baseLength * height / 2;
                        Console.WriteLine($"Площадь треугольника S = {S}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе значений.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите длины сторон четырехугольника: ");

                    if (double.TryParse(Console.ReadLine(), out double a) && double.TryParse(Console.ReadLine(), out double b) && double.TryParse(Console.ReadLine(), out double c) && double.TryParse(Console.ReadLine(), out double d) && a > 0 && b > 0 && c > 0 && d > 0)
                    {
                        double semiperimeter = (a + b + c + d) / 2;
                        S = Math.Sqrt((semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c) * (semiperimeter - d));
                        Console.WriteLine($"Площадь четырехугольника S = {S}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе значений.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Введите значение радиуса круга: ");

                    if (double.TryParse(Console.ReadLine(), out double R) && R > 0)
                    {
                        S = Math.PI * Math.Pow(R, 2);
                        Console.WriteLine($"Площадь круга S = {S}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе значения.");
                    }
                    break;
            }
        }

        static void perimeter()
        {
            double P;
            double a;
            double b;
            double c;
            switch (shapeSelection)
            {
                case "1":
                    Console.WriteLine("Введите длины сторон треугольника: ");

                    if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c) && a > 0 && b > 0 && c > 0)
                    {
                        P = a + b + c;
                        Console.WriteLine($"Периметр треугольника P = {P}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе значения.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите длины сторон четырехугольника: ");
                    if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c) && double.TryParse(Console.ReadLine(), out double d) && a > 0 && b > 0 && c > 0 && d > 0)
                    {
                        P = a + b + c + d;
                        Console.WriteLine($"Периметр четырехугольника P: = {P}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе значения.");
                    }
                    break;
                case "3":
                    Console.Write("Введите значение радиуса круга: ");
                    if (double.TryParse(Console.ReadLine(), out double R) && R > 0)
                    {
                        P = 2 * Math.PI * R;
                        Console.WriteLine($"Периметр круга P = {P}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе значения.");
                    }
                    break;
            }

        }
    }
}