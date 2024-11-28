// Дано целое число. Вывести его строку-описание вида «отрицательное четное число»,
// «нулевое число», «положительное нечетное число» и т. д. 
using System;
using System.ComponentModel.Design;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите целое число");
            int numb = Int32.Parse(Console.ReadLine());
            int evenNumb = numb % 2;
            {if ((evenNumb == 0) ^ (numb == 0))
            {
                Console.WriteLine("нулевое число");
            }}

            bool PositNegat = (numb > 0);
            bool EvenOdd = (numb % 2 == 0);

            {
                if ((PositNegat == true) ^ (EvenOdd == true))
                {
                    Console.WriteLine("Положительное четное число");
                }
                else if ((PositNegat == true) ^ (EvenOdd == false))
                {
                    Console.WriteLine("Положительное нечетное число");
                }
                else if ((PositNegat == false) ^ (EvenOdd == true))
                {
                    Console.WriteLine("Негативное положительное число");
                }
                else if ((PositNegat == false) ^ (EvenOdd == false))
                {
                    Console.WriteLine("Отрицательное нечетное число");
                }
            }

            Console.ReadKey();

        }
            
        }
    }
