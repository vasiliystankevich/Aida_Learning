// . Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной
// сумму этих значений, а если равны, то присвоить переменным нулевые значения. Вывести новые значения
// переменных A и B.

using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите две переменные целого типа: ");
            string[] arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            if (a != b)
            {
                a = a + b;
                b = a; 
                Console.WriteLine($" А = {a}, В = {b}");
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($" А = {a}, В = {b}");
            }

            Console.ReadKey();

        }
    }
}