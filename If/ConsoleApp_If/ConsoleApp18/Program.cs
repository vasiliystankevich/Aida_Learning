// Даны три целых числа, одно из которых отлично от двух других, равных между собой.
// Определить порядковый номер числа, отличного от остальных

using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите три целых числа: ");
            var  arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c = Convert.ToInt32(arr[2]);
            if (a == b)
            {
                Console.WriteLine("third");
            }
            else if (a == c)
            {
                Console.WriteLine("second");
            }    
            else if (c == b)    
            {
                Console.WriteLine("first");
            }
            
            
            
            Console.ReadKey();

        }
    }
}