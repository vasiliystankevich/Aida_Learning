// Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию, то удвоить их;
// в противном случае заменить значение каждой переменной на противоположное.
// Вывести новые значения переменных A, B, C. 

using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите три числа: ");
            var  arr = Console.ReadLine().Split();
            double a = Convert.ToDouble(arr[0]);
            double b = Convert.ToDouble(arr[1]);
            double c = Convert.ToDouble(arr[2]);
            if ((a > b) & (b > c) )
            {
                a = a * 2;
                b = b * 2;
                c = c * 2;
                

                Console.WriteLine($"{a}, {b}, {c}"); 
                //Console.WriteLine(a*2 + b*2 + c*2);
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
                Console.WriteLine($" {a}, {b}, {c} ");
            }
           
            Console.ReadKey();

        }
    }
}