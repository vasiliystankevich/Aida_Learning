// Даны четыре целых числа, одно из которых отлично от трех других, равных между собой.
// Определить порядковый номер числа, отличного от остальных

using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите четыре целых числа: ");
            var  arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c = Convert.ToInt32(arr[2]);
            int d = Convert.ToInt32(arr[3]);
            if ((a == b) & (b == c))
            {
                Console.WriteLine("fourth");
            }
            else if ((a == c) & (c == d))
            {
                Console.WriteLine("second");
            }    
            else if ((a == b) & (b == d))     
            {
                Console.WriteLine("third");
            }
            else     
            {
                Console.WriteLine("first");
            }
            
            
            
            Console.ReadKey();

        }
    }
}