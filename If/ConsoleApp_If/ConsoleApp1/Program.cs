//Дано целое число. Если оно является положительным, то прибавить к
//нему 1; в противном случае не изменять его. Вывести полученное число.
using System;

namespace ConsoleApp1
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
                int b = a + 1;
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}

