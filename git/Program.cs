using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { -10, 40, 13, -7, 99, -3, 2, 6, -2, 22 };
            int C, count = 0, index = 0, maxElement = arr[0], proizvedenie = 1;

            Console.Write("Введите С: ");
            C = int.Parse(Console.ReadLine());

            foreach (int tmp in arr)
                if (tmp > C)
                    count++;

            Console.WriteLine("Кол-во элементов больших С: " + count);

            for (int i = 1; i < arr.Length; i++)
                if (Math.Abs(maxElement) < Math.Abs(arr[i]))
                {
                    index = i;
                    maxElement = arr[i];
                }

            Console.WriteLine("Максимальный по модулю элемент равен {0}, его индекс равен {1}", maxElement, index);

            
            if (index != (arr.Length - 1))
            {
                for (int i = index + 1; i < arr.Length; i++)
                    proizvedenie *= arr[i];
                Console.WriteLine("Произведение равно " + proizvedenie);
            }
            else
            {
                Console.WriteLine("Максимальный по модулю элемент является последним в массиве.");
            }

            Console.ReadKey(true);
        }
    }
}