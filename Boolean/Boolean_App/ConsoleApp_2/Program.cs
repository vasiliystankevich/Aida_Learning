// Дано целое число A. Проверить истинность высказывания: «Число A является нечетным»

using System;

namespace ConsoleApp_2
{
    class Proram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            bool c = (a % 2 != 0);
            
            if (a % 2 == 0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("нечетное");
            }

            Console.ReadKey();
        }
    }
}

