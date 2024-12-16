//Единицы массы пронумерованы следующим образом: 1 — килограмм, 2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер.
//Дан номер единицы массы (целое число в диапазоне 1–5) и масса тела в этих единицах (вещественное число).
//Найти массу тела в килограммах
using System;

namespace ConsoleApp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите номер единицы массы в диапазоне 1–5 и массу тела в этих единицах: ");
            var arr = Console.ReadLine().Split();
            int massNumber = Convert.ToInt32(arr[0]);
            double mass = Convert.ToInt32(arr[1]);
            switch (massNumber)
            {
                case 1:
                    double massKg = mass;
                    Console.WriteLine(massKg);
                    break;
                case 2:
                    double massMgKg = mass * 1000000 ;
                    Console.WriteLine(massMgKg);
                    break;
                case 3:
                    double massGrKg = mass * 1000000 ;
                    Console.WriteLine(massGrKg);
                    break;
                case 4:
                    double massTonKg = mass / 1000 ;
                    Console.WriteLine(massTonKg);
                    break;
                case 5:
                    double massCenKg = mass / 100 ;
                    Console.WriteLine(massCenKg);
                    break;
                default:
                    Console.WriteLine("неверный ввод");
                    break;
            }

            Console.ReadKey();
        }
    }
}