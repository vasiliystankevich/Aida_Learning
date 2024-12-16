// Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста,
// обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
// 41 — «сорок один год». 
using System;

namespace ConsoleApp_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите  возраст ( от 20 до 69) : ");
            var age = Convert.ToInt32(Console.ReadLine());
            
            if (age < 20 || age > 69)
            {
                Console.WriteLine("Ошибка: число должно быть от 10 до 40");
                return;
                
            }

            var ageToStr = age switch
            {
                >= 20 and <= 29 => "двадцать",
                >= 30 and <= 39 => "тридцать",
                >= 40 and <= 49 => "сорок",
                >= 50 and <= 59 => "пятьдесят",
                >= 60 and <= 69 => "шестьдесят",
            };

            if (age % 10 != 0)
                ageToStr = (age % 10) switch 
                {
                    1 => $"{ageToStr} один",
                    2 => $"{ageToStr} два",
                    3 => $"{ageToStr} три",
                    4 => $"{ageToStr} четыре",
                    5 => $"{ageToStr} пять",
                    6 => $"{ageToStr} шесть",
                    7 => $"{ageToStr} семь",
                    8 => $"{ageToStr} восемь",
                    9 => $"{ageToStr} девять"
                };

            var taskFrom = "лет";
            if (age >= 20 || age <= 69)
                taskFrom = (age % 10) switch
                {
                    0 => "лет",
                    1 => "год",
                    2 => "года",
                    3 => "года",
                    4 => "года",
                    5 => "лет",
                    6 => "лет",
                    7 => "лет",
                    8 => "лет",
                    9 => "лет",
                };
            Console.WriteLine($"{age} — «{ageToStr} {taskFrom}»");
            Console.ReadKey();
        }
    }
}
