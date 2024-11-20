//Дано целое число. Если оно является положительным, то прибавить к
//нему 1; в противном случае вычесть из него 2. Вывести полученное число.

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"{a + 1}");
            }
            else
            {
                Console.WriteLine($"{a - 2}");
            }

            Console.ReadKey();

        }
    }
}

