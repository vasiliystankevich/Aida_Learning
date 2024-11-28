// Для данного целого x найти значение следующей функции f, принимающей значения целого типа: 
//f(x)  =  2·x, если x < −2 или x > 2,  
  //  −3·x в противном случае. 
using System;

namespace ConsoleApp25
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine("ВВедите значение Х: ");
      int valueX = Int32.Parse(Console.ReadLine());

      if ((valueX < -2) ^ (valueX > 2))
      {
        int argX = 2 * valueX;
        Console.WriteLine(argX);
      }
      else 
      {
        int argX = -3 * valueX;
        Console.WriteLine(argX);
      }

      Console.ReadKey();


    }
  }
}