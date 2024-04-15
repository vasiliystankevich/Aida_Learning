// Дан размер файла в байтах. Используя операцию деления нацело, найти количество полных килобайтов,
// которые занимает данный файл (1 килобайт = 1024 байта)

using System;

namespace ConsoleApp_3
{
    class Program
    {
        static void Main(string[] argh)
        {
            Console.Write("File Byte = ");
            int FileByte = int.Parse(Console.ReadLine());
            int FileKb = FileByte / 1024;
            Console.Write($"File Kb = {FileKb}");
            Console.ReadKey();
        }
    }
}