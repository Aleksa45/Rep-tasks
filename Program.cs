using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;

            do
            {
                Console.WriteLine("Что вы хотите сделать: \n 1 - ступенчатый массив \n 2 - создать и вывести одном массив \n 3 - посчитать сумму, ср ар и изм массив \n 4 - посчитать сумму \n 5 - посчитать произведение \n 6 - посчитать сумму и произв \n 0 - выход из программы  ");
                t = Convert.ToInt32(Console.ReadLine());

                switch(t)
                {
                    case 1:
                        ArrayOfArrays();
                        break;
                    case 2:
                        Console.WriteLine("Введите длину массива: ");
                        int kol = Convert.ToInt32(Console.ReadLine());
                        int[] mas = new int[kol];
                        mas = Input(kol);
                        Show(mas);
                        break;
                    case 3:
                        Console.WriteLine("Введите длину массива: ");
                        int kol1 = Convert.ToInt32(Console.ReadLine());
                        int[] mas1 = new int[kol1];
                        mas1 = Input(kol1);
                        int sum;
                        double sr;
                        int[] outputMas;
                        SumAr(mas1, out sum, out sr, out outputMas);
                        Console.WriteLine($"Сумма = {sum}, ср ар= {sr}");
                        Show(outputMas);
                        break;
                    case 4:
                        Console.WriteLine("Введите 2 числа: ");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Сумма {Sum(x1, y1)}");
                        break;
                    case 5:
                        Console.WriteLine("Введите 2 числа: ");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Произведение {Pr(x2, y2)}");
                        break;
                    case 6:
                        Console.WriteLine("Введите 2 числа: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int s, p;
                        SumPr(x, y, out s, out p);
                        Console.WriteLine($"Сумма {s}, произведение {p}");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Вы ввели несуществующую задачу!");
                        break;
                }
            }
            while (t != 0);

            Console.ReadKey();
        }

        static int[] Input(int kol)
        {
            int[] mas = new int[kol];
            Random rand = new Random();

            for (int i = 0; i < kol; i++)
            {
                mas[i] = rand.Next(0, 50);
            }
            return mas;
        }

        static void Show(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
        }

        static void SumAr(int[] mas, out int sum, out double sr, out int[] outputMas)
        {
            sum = 0;
            outputMas = new int[mas.Length];

            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            sr = sum * 1.0 / mas.Length;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] >= sr - 1 && mas[i] <= sr + 1)
                {
                    outputMas[i] = 0;
                }
                else { outputMas[i] = mas[i]; }
            }
        }

        static void SumPr(int x, int y, out int s, out int p)
        {
            s = x + y;
            p = x * y;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Pr(int b, int c)
        {
            return b * c;
        }
        static void ArrayOfArrays()
        {
            Random random = new Random();
            Console.WriteLine("Введ кол строк: ");
            int kol = Convert.ToInt32(Console.ReadLine());
            int[][] name = new int[kol][];

            for(int i =0; i < kol; i++)
            {
                Console.WriteLine($"Сколько в страке {i} будет элементов?");
                name[i] = new int [Convert.ToInt32(Console.ReadLine())];

                for (int j = 0; j < name[i].Length; j++)
                {
                    name[i][j] = random.Next(0,100); 
                }
            }

            for(int i = 0; i < kol; i++)
            {
                for(int j = 0; j < name[i].Length; j++)
                {
                    Console.Write(name[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
