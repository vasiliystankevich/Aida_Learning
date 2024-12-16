// Даны два целых числа: D (день) и M (месяц), определяющие правильную дату невисокосного года.
// Вывести значения D и M для даты, следующей за указанной. 

using System;

namespace ConsoleApp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите день и месяц(два целых числа): ");
            var arr = Console.ReadLine().Split();
            int dayNumber = Convert.ToInt32(arr[0]);
            int monthNumber = Convert.ToInt32(arr[1]);
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 11:
                    if (dayNumber >= 1 && dayNumber < 31)
                    {
                        int nextD = dayNumber + 1;
                        int nextM = monthNumber;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else if (dayNumber == 31)
                    {
                        int nextD = 1;
                        int nextM = monthNumber + 1;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else
                    {
                        Console.WriteLine("неверное число");
                    }
                    Console.WriteLine($"c");
                        break;
                case 2:
                    if (dayNumber >= 1 && dayNumber < 28)
                    {
                        int nextD = dayNumber + 1;
                        int nextM = monthNumber;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else if (dayNumber == 28)
                    {
                        int nextD = 1;
                        int nextM = monthNumber + 1;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else
                    {
                        Console.WriteLine("неверное число");
                    }
                    break;
                case 4:
                case 6:
                case 8:
                case 10:
                    if (dayNumber >= 1 && dayNumber < 30)
                    {
                        int nextD = dayNumber + 1;
                        int nextM = monthNumber;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else if (dayNumber == 30)
                    {
                        int nextD = 1;
                        int nextM = monthNumber + 1;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else
                    {
                        Console.WriteLine("неверное число");
                    }
                    break;
                case 12:
                    if (dayNumber >= 1 && dayNumber < 31)
                    {
                        int nextD = dayNumber + 1;
                        int nextM = monthNumber;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else if (dayNumber == 31)
                    {
                        int nextD = 1;
                        int nextM = 1;
                        Console.WriteLine($"next day: {nextD}, next month: {nextM}");
                    }
                    else
                    {
                        Console.WriteLine("неверное число");
                    }
                    break;
                default:
                    Console.WriteLine("неверный ввод");
                    break;
            }
            

            Console.ReadKey();
        }
    }
}