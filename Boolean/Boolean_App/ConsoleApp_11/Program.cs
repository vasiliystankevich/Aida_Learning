// Даны два целых числа: A, B. Проверить истинность высказывания: «Числа A и B имеют одинаковую четность»

using System;

namespace ConsoleApp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите два целых числа А и В: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            bool c = (a % 2 == 0) & (b % 2 == 0);
            bool d = (a % 2 != 0) & (b % 2 != 0);
            if (c)
            {
                Console.WriteLine("Числа А и В имеют одинаковую четность");
            }
            else if (d)
            {
                Console.WriteLine("Числа А и В имеют одинаковую четность");
            }
            else
            {
                Console.WriteLine("Числа А и В не имеют одинаковую четность");
            }
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            Console.ReadKey();
            //switch (c)
            //{
                //case "true":
                   // Console.WriteLine(c);
                   // break;  ?????Через  swith не получается из за типа переменной bool??
                
            



        }
    }
}