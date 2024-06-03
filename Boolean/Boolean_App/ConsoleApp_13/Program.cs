// . Даны три целых числа: A, B, C. Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное»

using System;

namespace ConsoleApp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите три целых числа - А, В и С: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            bool d = a > 0 | b > 0 | c > 0;
            Console.WriteLine("Высказывание 'Хотя бы одно из трех чисел положительное' - {0}", d);
            Console.ReadKey();
        }
    }
}
        
        
            
            
    
