// Дано целое число в диапазоне 1–7. Вывести строку — название дня недели, соответствующее данному числу
// (1 — «понедельник», 2 — «вторник» и т. д.). 
using System;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите целое число в диапазоне от 1 до 7: ");
            int numb = Int32.Parse(Console.ReadLine());

            switch (numb)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
                case 7:
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("неверное число");
                    break;
            }

            Console.ReadKey();
        }
    }
}

