// Дни недели пронумерованы следующим образом: 1 — понедельник, 2 — вторник, . . . , 6 — суббота,
// 7 — воскресенье. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня
// года, если известно, что в этом году 1 января было вторником.

using System;

namespace ConsoleApp_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите число от 1 до 365: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = (k % 7) + 1;
            if (a == 0)
            {
                Console.WriteLine($"{a} - Воскресенье");
            }
            else if (a == 1)
            {
                Console.WriteLine($"{a} - Понедельник");
            }
            else if (a == 2)
            {
                Console.WriteLine($"{a} - Вторник");
            }
            else if (a == 3)
            {
                Console.WriteLine($"{a} - Среда");
            }
            else if (a == 4)
            {
                Console.WriteLine($"{a} - Четверг");
            }
            else if (a == 5)
            {
                Console.WriteLine($"{a} - Пятница");
            }
            else if (a == 6)
            {
                Console.WriteLine($"{a} - Суббота");
            }

            Console.ReadKey();


        }
        
    }
}

