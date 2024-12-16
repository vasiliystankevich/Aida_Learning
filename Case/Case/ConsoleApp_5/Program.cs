// Арифметические действия над числами пронумерованы следующим образом: 1 — сложение, 2 — вычитание, 3 — умножение,
// 4 — деление. Дан номер действия N (целое число в диапазоне 1–4) и вещественные числа A и B (B не равно 0).
// Выполнить над числами указанное действие и вывести результат. 
using System;

namespace ConsoleApp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите целое число в диапазоне от 1 до 12: ");
            var arr = Console.ReadLine().Split();
            int action = Convert.ToInt32(arr[0]);
            int numberA = Convert.ToInt32(arr[1]);
            int numberB = Convert.ToInt32(arr[2]);
            

            switch (action)
            {
                case 1:
                    int actionSum = numberA + numberB;
                    Console.WriteLine(actionSum);
                    break;
                case 2:
                    int actionDifference = numberA - numberB;
                    Console.WriteLine(actionDifference);
                    break;
                case 3:
                    
                        int actionProduct = numberA * numberB;
                        Console.WriteLine(actionProduct);
                    break;
                case 4:
                    if (numberB != 0)
                    {
                        int actionQuotient = numberA / numberB;
                        Console.WriteLine(actionQuotient);
                        
                    }
                    else
                    {
                        Console.WriteLine("неверный ввод");
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