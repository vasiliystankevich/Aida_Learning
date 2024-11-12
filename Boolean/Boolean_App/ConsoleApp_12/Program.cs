// Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».

using System;

namespace ConsoleApp_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите три целых числа - А, В и С: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            bool t = a > 0 & b > 0 & c > 0;
            if (t)
            {
                Console.WriteLine("Каждое из трех чисел положительное");
            }
            else
            {
                Console.WriteLine("Не каждое из трех чисел положительное");
            }

            Console.ReadKey();
        }
            
                
            }
            
        }
    
