using System;

class Task17
{
    static void Main()
    
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите количество заданий (от 10 до 40):");
        
        var number = int.Parse(Console.ReadLine());
        if (number < 10 || number > 40)
        {
            Console.WriteLine("Ошибка: число должно быть от 10 до 40");
            return;
        }

        var numberToStr = number switch
        {
            10 => "десять",
            11 => "одиннадцать",
            12 => "двенадцать",
            13 => "тринадцать",
            14 => "четырнадцать",
            15 => "пятнадцать",
            16 => "шестнадцать",
            17 => "семнадцать",
            18 => "восемнадцать",
            19 => "девятнадцать",
            >= 20 and <= 29 => "двадцать",
            >= 30 and <= 39 => "тридцать",
            40 => "сорок"
        };

        if (number >= 21 && number <= 29 || number >= 31 && number <= 39)
            numberToStr = (number % 10) switch
            {
                1 => $"{numberToStr} одно",
                2 => $"{numberToStr} два",
                3 => $"{numberToStr} три",
                4 => $"{numberToStr} четыре",
                5 => $"{numberToStr} пять",
                6 => $"{numberToStr} шесть",
                7 => $"{numberToStr} семь",
                8 => $"{numberToStr} восемь",
                9 => $"{numberToStr} девять"
            };

        var lastDigit = number % 10;
        var lastTwoDigits = number % 100;
        var taskForm = "учебных заданий";

        if (lastTwoDigits < 11 || lastTwoDigits > 19)
            taskForm = lastDigit switch
            {
                1 => "учебное задание",
                2 => "учебных задания",
                3 => "учебных задания",
                4 => "учебных задания",
                _ => taskForm
            };

        Console.WriteLine($"{number} — «{numberToStr} {taskForm}»");
    }
}