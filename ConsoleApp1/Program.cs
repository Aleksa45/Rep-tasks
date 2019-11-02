using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое задание вы хотите: \n 1 - арифм действие \n 2 - проверка на четность \n 3 - среднее арифм \n 4 - разряды числа \n 0 - выход из прогр");
            int t = Convert.ToInt32(Console.ReadLine());

            switch (t)
            {
                case 1:
                    Console.WriteLine("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите + или - : ");
                    string p = Console.ReadLine();
                    int a = p == "+" ? (n + h) : (n - h);
                    Console.WriteLine($" a = {n} {p} {h} = {a}");
                    break;

                case 2:
                    Console.WriteLine("Введите число: ");
                    int s = Convert.ToInt32(Console.ReadLine());
                    if ((s & 1) == 0)
                    {
                        Console.WriteLine($"Число {s} четное");
                        Console.Write("Четные числа до него: ");
                        for (int i = s; i > 0; i -= 2)
                        {
                            Console.Write(" " + i);
                        }
                        Console.WriteLine();
                    }
                    else Console.WriteLine($"Число {s} нечетное");
                    break;

                case 3:
                    Console.WriteLine("Введите число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    double f = (b + c) / 2.0;
                    Console.WriteLine("Среднее арифм = " + f);
                    break;

                case 4:
                    Console.WriteLine("Введите число от 99 до 1000: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ваше число: {d} ");
                    int w = 0;
                    Console.Write("По разрядам: ");
                    for (int i = 100; i > 0; i /= 10)
                    {
                        w = d / i;
                        Console.Write(w + " ");
                        d %= i;
                    }
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Вы ввели несуществующее задание");
                    break;
            }

            Console.ReadLine();
        }
    }
}
