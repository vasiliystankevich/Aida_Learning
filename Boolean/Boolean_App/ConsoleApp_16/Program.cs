// Дано целое положительное число. Проверить истинность высказывания: «Данное число является
// четным двузначным».

using System;
using System.ComponentModel.Design;

namespace ConsoleApp_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите целое положительное число: ");
            int a  = Convert.ToInt32(Console.ReadLine());
            if ((a > 0) & ((a % 2) == 0) & (a < 100 ))
            { 
                Console.WriteLine("Число является четным двузначным");
            }
            else
            {
                Console.WriteLine("число не является четным двузначным");
            }

            Console.ReadKey();
            


        }
    }
}