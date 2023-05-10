using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ТАБУЛИРОВАНИЕ ФУНКЦИИ");
            Console.WriteLine("\nВведите X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("и его конец");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг, на который будет увеличиваться X");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nX        Y");
            while (x < a)
            {
                x = x + h;
            }
            int count = 0;
            int notx = x;
            while (notx <= b)
            {
                notx = notx + h;
                count++;
            }
            double[,] array = new double[count, 2];
            double max = 0;
            double min = 0;
            for (int i = 0; x <= b; i++)
            {
                array[i, 0] = x;
                Console.Write($"{array[i, 0]}      ");
                array[i, 1] = Math.Round(Math.Cos(Math.Pow(x, 2)) + Math.Pow(Math.Sin(x), 2), 2);
                Console.WriteLine($"{array[i, 1]}\n");
                if (i == 0)
                {
                    max = array[i, 1];
                    min = array[i, 1];
                }
                if (max < array[i, 1])
                    max = array[i, 1];
                if (min > array[i, 1])
                    min = array[i, 1];
                x = x + h;
            }
            Console.WriteLine($"Кол-во точек в таблице: {count}");
            Console.WriteLine($"\nМаксимальное значение функции: {max}");
            Console.WriteLine($"Минимальное значение функции: {min}\n");
            int count2 = 0;
            for (int i = 1; i < count; i++)
            {
                if (array[i, 1] < 0)
                    if (array[i - 1, 1] > 0)
                        count2++;
                if (array[i, 1] > 0)
                    if (array[i - 1, 1] < 0)
                        count2++;
            }
            Console.WriteLine($"Функция {count2} раз(а) меняет знак на противоположный");
        }
    }
}
