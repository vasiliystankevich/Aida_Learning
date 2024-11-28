// Дан номер года (положительное целое число). Определить количество дней в этом году, учитывая,
// что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год, делящийся на 4,
// за исключением тех годов, которые делятся на 100 и не делятся на 400 (например, годы 300, 1300 и 1900 не
// являются високосными, а 1200 и 2000 — являются). 
using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите номер года");
            double year = Double.Parse(Console.ReadLine());
            double divide4 = year % 4;
            double divide100 = year % 100;
            double divide400 = year % 400;
            bool fc = ((divide100 == 0) & (divide400 != 0));


            
                if ((divide4 == 0) & (fc == false))
                {
                    Console.WriteLine("366");
                }
                else if (fc == true)
                {
                    Console.WriteLine("365");
                }
                else
                {
                    Console.WriteLine("365");
                }

                Console.ReadKey();
        }
    }
}


