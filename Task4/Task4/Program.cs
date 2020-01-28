using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection_method;
            string A;
            string B;
            string C;
            string D;
            string H;
            double a;
            double b;
            double c;
            double d;
            double h;
            double S;
            double P;
            double p;
            Console.WriteLine("Выберите фигуру для которой будет рассчитана площадь или периметр (введите одну из цифр, указанных ниже):");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Четырехугольник");
            Console.WriteLine("3. Круг\n\n");
            string selection_fig = Console.ReadLine();

            switch (selection_fig)
            {
                case "1":
                    Console.WriteLine("Вы выбрали треугольник.\n\n");
                    Console.WriteLine("Выберите что будет рассчитано (введите одну из цифр, указанных ниже:");
                    Console.WriteLine("1. Площадь");
                    Console.WriteLine("2. Периметр\n\n");
                    selection_method = Console.ReadLine();

                    switch (selection_method)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали расчет площади.\n");
                            Console.Write("Введите высоту треугольника: ");
                            H = Console.ReadLine();
                            if (double.TryParse(H, out h))
                            {
                                Console.Write("Введите длину основания треугольника: ");
                                A = Console.ReadLine();
                                if (double.TryParse(A, out a))
                                {
                                    S = a * h / 2;
                                    Console.WriteLine($"Площадь треугольника S = {S}");
                                }
                                else Console.WriteLine("Неверно введено значение основания треугольника");
                            }
                            else Console.WriteLine("Невернно введено значение высоты треугольника");
                            break;

                        case "2":
                            Console.WriteLine("Вы выбрали расчет периметра.\n");
                            Console.Write("Введите длину стороны a: ");
                            A = Console.ReadLine();
                            if (double.TryParse(A, out a))
                            {
                                Console.Write("Введите длину стороны b: ");
                                B = Console.ReadLine();
                                if (double.TryParse(B, out b))
                                {
                                    Console.Write("Введите длину стороны c: ");
                                    C = Console.ReadLine();
                                    if (double.TryParse(C, out c))
                                    {
                                        P = a + b + c;
                                        Console.WriteLine($"Периметр треугольника P = {P}");
                                    }
                                    else Console.WriteLine("Неверно введено значение длины стороны c.");
                                }
                                else Console.WriteLine("Неверно введено значение длины стороны b.");
                            }
                            else Console.WriteLine("Неверно введено значение стороны a.");
                            break;

                        default:
                            Console.WriteLine("Вы сделали неправильный выбор.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("Вы выбрали четырехугольник.\n\n");
                    Console.WriteLine("Выберите что будет рассчитано (введите одну из цифр, указанных ниже:");
                    Console.WriteLine("1. Площадь");
                    Console.WriteLine("2. Периметр\n\n");
                    selection_method = Console.ReadLine();
                    switch (selection_method)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали расчет площади.\n");
                            Console.Write("Введите длину сторны a: ");
                            A = Console.ReadLine();
                            if (double.TryParse(A, out a))
                            {
                                Console.Write("Введите длину стороны b: ");
                                B = Console.ReadLine();
                                if (double.TryParse(B, out b))
                                {
                                    Console.Write("Введите длину стороны c: ");
                                    C = Console.ReadLine();
                                    if (double.TryParse(C, out c))
                                    {
                                        Console.Write("Введите длину стороны d: ");
                                        D = Console.ReadLine();
                                        if (double.TryParse(D, out d))
                                        {
                                            p = (a + b + c + d) / 2;
                                            S = Math.Sqrt((p-a)*(p-b)*(p-c)*(p-d));
                                            Console.WriteLine($"Площадь четырехугольника S = {S}");
                                        }
                                        else Console.WriteLine("Неверно введено значение стороны d.");
                                    }
                                    else Console.WriteLine("Неверно введено значение длины стороны c.");
                                }
                                else Console.WriteLine("Неверно введено значение длины стороны b.");
                            }
                            else Console.WriteLine("Неверно введено значение длины стороны a.");
                            break;

                        case "2":
                            Console.WriteLine("Вы выбрали расчет периметра.\n");
                            Console.Write("Введите длину сторны a: ");
                            A = Console.ReadLine();
                            if (double.TryParse(A, out a))
                            {
                                Console.Write("Введите длину стороны b: ");
                                B = Console.ReadLine();
                                if (double.TryParse(B, out b))
                                {
                                    Console.Write("Введите длину стороны c: ");
                                    C = Console.ReadLine();
                                    if (double.TryParse(C, out c))
                                    {
                                        Console.Write("Введите длину стороны d: ");
                                        D = Console.ReadLine();
                                        if (double.TryParse(D, out d))
                                        {
                                            P = a + b + c + d;
                                            Console.WriteLine($"Периметр четырехугольника P: = {P}");
                                        }
                                        else Console.WriteLine("Неверно введено значение стороны d.");
                                    }
                                    else Console.WriteLine("Неверно введено значение длины стороны c.");
                                }
                                else Console.WriteLine("Неверно введено значение длины стороны b.");
                            }
                            else Console.WriteLine("Неверно введено значение длины стороны a.");
                            break;

                        default:
                            Console.WriteLine("Вы сделали неправильный выбор.");
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("Вы выбрали круг.");
                    break;

                default:
                    Console.WriteLine("Вы сделали неправильный выбор.");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
