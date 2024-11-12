//С начала суток прошло N секунд (N — целое). Найти количество полных часов, прошедших с начала суток

using System;

namespace ConsoleApp_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("seconds: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a / 60) / 60;
            Console.WriteLine(b + "hour");
            Console.ReadKey();
            
        }
    }
}