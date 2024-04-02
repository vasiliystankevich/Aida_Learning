// Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). Найти площади этих кругов S1 и S2,
// а также площадь S3 кольца, внешний радиус которого равен R1, а внутренний радиус равен R2
// КАК указать что р1 больше р2?

using System;

namespace ConsoleApp
{
    class programm
    {
        static void Main(string[] argh)
        {
            Console.Write("r1 = ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r2 = ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double p = 3.14;

            double S1 = p * Math.Pow(r1, 2);
            double S2 = p * Math.Pow(r2, 2);
            double S3 = S1 - S2;
            
            Console.WriteLine($"S1 = {S1}, S2 = {S2}, S3 = {S3}");
            Console.ReadKey();
        }
    }
}