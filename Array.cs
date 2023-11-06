using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();

        }

        private static void ex3()
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите 2 целых числа: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x + y > n)
            {
                Console.WriteLine("Вы ввели слишком большие числа");
            }
            Console.WriteLine("После сортировки по возрастанию:");
            Array.Sort(a, a[x], a[y]);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Отсортировали по убыванию:");
            Array.Reverse(a);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void ex2()
        {
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(0, 10);
                Console.WriteLine(mass[i]);
            }
            Array.Reverse(mass);
            Console.WriteLine("После Reverse: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }

        private static void ex1()
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите число которое хотите найти в массиве: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Array.IndexOf(a, b);
            int d = Array.LastIndexOf(a, c);
            if (c >= 0 && d >= 0)
            {
                Console.WriteLine("Индекс первого вхождения этого числа: " + c);
                Console.WriteLine("Индекс последнего вхождения этого числа: " + d);
            }
            else
            {
                Console.WriteLine("Такого числа нет");
            }
        }
    }
}
