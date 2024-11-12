// С начала суток прошло N секунд (N — целое). Найти количество секунд, прошедших с начала последней минуты

using System;

namespace ConsoleApp_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("second: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a % 60;
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}