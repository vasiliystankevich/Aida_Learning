// Дан номер месяца — целое число в диапазоне 1–12 (1 — январь, 2 — февраль и т. д.). Вывести название
// соответствующего времени года («зима», «весна», «лето», «осень»). 
using System;

namespace ConsoleApp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите целое число в диапазоне от 1 до 12: ");
            int numMonth = Int32.Parse(Console.ReadLine());

            switch (numMonth)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("осень");
                    break;
                default:
                    Console.WriteLine("неверное число");
                    break;
            }

            Console.ReadKey();
        }
    }
}