// Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 — понедельник, 2 — вторник, . . . ,
// 6 — суббота. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня года,
// если известно, что в этом году 1 января было понедельником

using System;

namespace ConsoleApp_24
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите число от 1 до 365: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 7;
            if (b == 0)
            {
                Console.WriteLine($"{b} - Воскресенье");
            }
            else if (b == 1)
            {
                Console.WriteLine($"{b} - Понедельник");
            }
            else if (b == 2)
            {
                Console.WriteLine($"{b} - Вторник");
            }
            else if (b == 3)
            {
                Console.WriteLine($"{b} - Среда");
            }
            else if (b == 4)
            {
                Console.WriteLine($"{b} - Четверг");
            }
            else if (b == 5)
            {
                Console.WriteLine($"{b} - Пятница");
            }
            else if (b == 6)
            {
                Console.WriteLine($"{b} - Суббота");
            }

            Console.ReadKey();
        

        {
                
            }

        }
    }
}