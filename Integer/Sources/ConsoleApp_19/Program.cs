//  С начала суток прошло N секунд (N — целое). Найти количество
// полных минут, прошедших с начала суток.

using System;

namespace ConsoleApp_19
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("прошедшие секунды: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 60;
            Console.WriteLine(b + "minut");
            Console.ReadKey();
        }
    }
}