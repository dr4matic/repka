
using morskoyboy;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamove = new Game();
            var firstplace = gamove.GetPlayerField(PlayerValue.First);
            var egg = firstplace.GetCellsValues();
            var bacon = 0;
            foreach (var vid in egg)
            
            {
                if (vid.y != bacon)
                {
                    Console.WriteLine();
                    bacon = vid.y;
                }
                Console.Write(vid);
                
            }
            /*var firstinvisibledplace = gamove.GetOpponentField(PlayerValue.Second);
            egg = firstinvisibledplace.GetCellsValues();
            foreach (var vids in egg)
            {
                Console.WriteLine(vids);
            }*/
        }
        static void Test(string[] args)
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
