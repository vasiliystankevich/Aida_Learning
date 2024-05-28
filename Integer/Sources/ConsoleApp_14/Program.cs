// Дано трехзначное число. В нем зачеркнули первую справа цифру
// и приписали ее слева. Вывести полученное число

 using System;

namespace ConsoleApp_14
{
 class Program
 {
  static void Main(string[] args)
  {
   Console.OutputEncoding = System.Text.Encoding.UTF8;
   Console.WriteLine("Введите трехзначное число: ");
   int a = Convert.ToInt32(Console.ReadLine());
   int b = a / 100;
   int c = (a / 10) % 10;
   int d = a  % 10;
   int f = d * 100 + b * 10 + c;
   Console.WriteLine(f);
   Console.ReadKey();
  }
 }
}