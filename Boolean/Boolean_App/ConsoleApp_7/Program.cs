// Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится между числами A и C

using System;
using System.Text;

namespace ConsoleApp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите последовательно числа А, В, С: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            //if (a < b && b < c ) && ( b < a && b > c) не сработало
            if (a < b && b < c )
            {
                Console.WriteLine("Число В находится между числами А и С");
            }
            else if ( b < a && b > c)
            {
                Console.WriteLine("Число В находится между числами А и С");
            }
            else
            {
                Console.WriteLine("Число В не находится между числами А и С");
            }

            Console.ReadKey();


        }
        }
    }
