// Дано целое число A. Проверить истинность высказывания: «Число A является положительным

using System;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите целое число а");
            int a = Convert.ToInt32(Console.ReadLine());
            bool b = a > 0;
            Console.WriteLine(b);
            Console.ReadKey();
            


        }
}
}
//int a;
//Console.Write(«A: «);
//a = Convert.ToInt16(Console.ReadLine());
//if (a > 0) Console.WriteLine(true);
//else Console.WriteLine(false);
// это решение с интернета, верно ли я решаю?