using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            string B;
            string C;
            string H;
            int a;
            int b;
            int c;
            int h;
            int S;
            int P;
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
                    string selection_method = Console.ReadLine();

                    switch (selection_method)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали расчет площади.\n");
                            Console.Write("Введите высоту треугольника: ");
                            H = Console.ReadLine();
                            if (int.TryParse(H, out h))
                            {
                                Console.Write("Введите длину основания треугольника: ");
                                A = Console.ReadLine();
                                if (int.TryParse(A, out a))
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
                            if (int.TryParse(A, out a))
                            {
                                Console.Write("Введите длину стороны b: ");
                                B = Console.ReadLine();
                                if (int.TryParse(B, out b))
                                {
                                    Console.Write("Введите длину стороны c: ");
                                    C = Console.ReadLine();
                                    if (int.TryParse(C, out c))
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
                    Console.WriteLine("Вы выбрали четырехугольник.");
                    break;

                case "3":
                    Console.WriteLine("Вы выбрали круг.");
                    break;

                default:
                    Console.WriteLine("Вы сделали неправильный выбор.");
                    break;
            }
        }
    }
}
