// Дано двузначное число. Вывести вначале его левую цифру (десятки), а затем — его правую цифру (единицы)
// . Для нахождения десятков использовать операцию деления нацело, для нахождения единиц
// — операцию взятия остатка от деления.

using System;

namespace ConsoleApp_6
{
    class Program

    {
        static void Main(string[] argh)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;            
            Console.Write("Введите двузначное число: ");
            int a = int.Parse(Console.ReadLine());
            int b = 10;
            int c = a / b;
            int result;
            int d = Math.DivRem(a, b, out result);
            Console.WriteLine($"Десятки: {c}, еденицы: {result}");
            Console.ReadKey();

        }


    }
}
// все задачи решать на англ? 