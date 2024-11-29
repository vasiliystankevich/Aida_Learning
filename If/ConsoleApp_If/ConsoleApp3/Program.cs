//  Дано целое число. Если оно является положительным, то прибавить к
// нему 1; если отрицательным, то вычесть из него 2; если нулевым, то
// заменить его на 10. Вывести полученное число

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
            else if (a < 0)
            {
                Console.WriteLine($"{a - 2}");
            }
            else if (a == 0)

            {
                a = 10;
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
        

        }
    }
