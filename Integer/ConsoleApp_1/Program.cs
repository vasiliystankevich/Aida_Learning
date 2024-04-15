// Дано расстояние L в сантиметрах. Используя операцию делениянацело, найти
// количество полных метров в нем (1 метр = 100 см)

using System;

namespace ConsoleApp_1
{
    class Programm
    {
        static void Main(string[] argh)
        {
             //  int L, Lm; почему нельзя это написать?
              Console.Write("L: ");
              int L = int.Parse(Console.ReadLine());
              int Lm = L / 100;
              Console.WriteLine("Lm:" + Lm);
              Console.ReadKey();
        }
    }
}