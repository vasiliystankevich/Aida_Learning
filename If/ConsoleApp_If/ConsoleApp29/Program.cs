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
            //int evenNumb = numb % 2;
            //{if ((evenNumb == 0) ^ (numb == 0))
            //{
              //  Console.WriteLine("нулевое число");
            //}}

            bool Posit = (numb > 0);
            bool Negat = (numb < 0);
            bool Even = (numb % 2 == 0);
            bool Odd = (numb % 2 != 0);

            {
                if ((Posit == true) & (Even == true))
                {
                    Console.WriteLine("Положительное четное число");
                }
                else if ((Posit == true) & (Odd == true))
                {
                    Console.WriteLine("Положительное нечетное число");
                }
                else if ((Negat == true) & (Even == true))
                {
                    Console.WriteLine("Негативное четное число");
                }
                else if ((Negat == true) & (Odd == true))
                {
                    Console.WriteLine("Отрицательное нечетное число");
                }
                else
                {
                    Console.WriteLine("нулевое число");
                }
            }

            Console.ReadKey();

        }
            
        }
    }
