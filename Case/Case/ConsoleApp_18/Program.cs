// Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 —
// «двести пятьдесят шесть», 814 — «восемьсот четырнадцать». 

using System;

namespace ConsoleApp_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите  число в диапазоне 100-999: ");
            var number = Convert.ToInt32(Console.ReadLine());
            
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число не находится в заданном диапазоне");
                return;
            }
            
            var hundreds = (number  / 100);

            var numberToStr = hundreds switch
            {
                1 => "сто",
                2 => "двести",
                3 => "триста",
                4 => "четыреста",
                5 => "пятьсот",
                6 => "шестьсот",
                7 => "семьсот",
                8 => "восемьсот",
                9 => "девятьсот",

            };

            var tens = (number % 100) /  10;
            var tensOne = number % 100;
            if (tensOne >= 11 && tensOne <= 19)
                numberToStr = tensOne switch
                {
                  11 => $"{numberToStr} одиннадцать", 
                  12 => $"{numberToStr} двенадцать",
                  13 => $"{numberToStr} тринадцать",
                  14 => $"{numberToStr} четырнадцать",
                  15 => $"{numberToStr} пятнадцать",
                  16 => $"{numberToStr} шестнадцать",
                  17 => $"{numberToStr} семнадцать",
                  18 => $"{numberToStr} восемнадцать",
                  19 => $"{numberToStr} девятнадцать",
                };
            if (tens != 0)
                numberToStr = tens switch
                {
                  1 => $"{numberToStr} десять",
                  2 => $"{numberToStr} двадцть",
                  3 => $"{numberToStr} тридцть",
                  4 => $"{numberToStr} сорок",
                  5 => $"{numberToStr} пятьдесят",
                  6 => $"{numberToStr} шестьдесят",
                  7 => $"{numberToStr} семьдесят" ,
                  8 => $"{numberToStr} восемьдесят",
                  9 => $"{numberToStr} девяносто",
                  
                };
            var units = number % 10;
            if (units != 0)
                numberToStr = units switch
                {
                    1 => $"{numberToStr} один",
                    2 => $"{numberToStr} два",
                    3 => $"{numberToStr} три",
                    4 => $"{numberToStr} четыре",
                    5 => $"{numberToStr} пять",
                    6 => $"{numberToStr} шесть",
                    7 => $"{numberToStr} семь",
                    8 => $"{numberToStr} восемь",
                    9 => $"{numberToStr} девять",

                };

            Console.WriteLine(numberToStr);
            Console.ReadKey();

        }
        
    }
}