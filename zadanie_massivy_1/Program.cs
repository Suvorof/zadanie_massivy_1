using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_massivy_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов массива");
            string x = Console.ReadLine();
            int kolich_elementov_massiva = Convert.ToInt32(x);

            int[] massiv = new int[kolich_elementov_massiva];
            Random rand = new Random();
            Console.WriteLine("Автоматическое заполнение масива произвольными целыми числами от 0 до 1000");
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rand.Next(0,1000);
                Console.WriteLine("{0}-й элемент массива равен {1}", i+1, massiv[i]);                               
            }

            int maxValue = massiv.Max();
            Console.WriteLine("Максимальное значение из элементов массива равно {0}", maxValue);

            int minValue = massiv.Min();
            Console.WriteLine("Минимальное значение из элементов массива равно {0}", minValue);

            int sumElementov = massiv.Sum();
            Console.WriteLine("Сумма всех элементов массива равна {0}", sumElementov);

            int sredneArifmeticheskoe = sumElementov / massiv.Length;
            Console.WriteLine("Среднеарифметическое элементов массива равно {0}", sredneArifmeticheskoe);

            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] % 2 != 0)
                {
                    Console.WriteLine("{0}-е нечётное число из массива {1}",i+1, massiv[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
