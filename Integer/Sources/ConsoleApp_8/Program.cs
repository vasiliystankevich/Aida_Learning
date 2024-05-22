// Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа

using System;

namespace ConsoleApp_8
{
    class Program
    {
        static void Main(string[] argh)
        {
            Console.WriteLine("Введите двузначное число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10 * 10 + a / 10;
            Console.WriteLine("Зеркало: " + b);
            Console.ReadKey();
        }
        
    }
}
