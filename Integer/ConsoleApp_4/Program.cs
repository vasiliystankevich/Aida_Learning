// Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков
// длины B (без наложений). Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.

using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
           // Console.WriteLine("В отрезке A содержится " + (int) a / b + " полных отрезков B.");
            int c = a / b;
            //Console.WriteLine($"В отрезке А содержится {c} полных отрезков В"); почему не работает 
            Console.WriteLine("C = " + c);
            Console.ReadKey();
            
        }
    }
}