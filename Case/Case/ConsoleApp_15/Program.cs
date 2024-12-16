// Мастям игральных карт присвоены порядковые номера: 1 — пики, 2 — трефы, 3 — бубны, 4 — червы. Достоинству карт,
// старших десятки, присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз. Даны два целых числа: N —
// достоинство (6 ≤ N ≤ 14) и M — масть карты (1 ≤ M ≤ 4). Вывести название соответствующей карты вида «шестерка бубен»,
// «дама червей», «туз треф» и т. п. 
using System;

namespace ConsoleApp_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите достоинство и масть карты: ");
            var arr = Console.ReadLine().Split();
            int suidCard  = Convert.ToInt32(arr[0]);
            int valueCard = Convert.ToInt32(arr[1]);
            string value = null, suid = null;
            switch (suidCard)
            {
                case 1: suid = "пик"; break;
                case 2: suid = "треф"; break;
                case 3: suid = "бубей"; break;
                case 4: suid = "червей"; break;
            }
            switch (valueCard)
            {
                case 5: value = "пятерка"; break;
                case 6: value = "шестерка"; break;
                case 7: value = "семерка"; break;
                case 8: value = "восьмерка"; break;
                case 9: value = "девятка"; break;
                case 10: value = "десятка"; break;
                case 11: value = "валет"; break;
                case 12: value = "дама"; break;
                case 13: value = "король"; break;
                case 14: value = "туз"; break;

            }
            Console.WriteLine($"{value} {suid}");
            Console.ReadKey();
        }
    }
}

