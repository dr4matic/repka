
using morskoyboy;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fort = new Field();
            var korabl = fort.SetCellValue(4, 5, CellValue.Ship);
            if (korabl)
            {
                Console.WriteLine("Корабль установлен");
            }
            korabl = fort.SetCellValue(4, 5, CellValue.Ship);
            if (!korabl)
            {
                Console.WriteLine("Корабль не установлен");
            }
            var hit = fort.CrashValue(4, 5);
            Console.WriteLine(hit);
        }
    }
}
