
using morskoyboy;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamove = new Game();
            gamove.Start();
            var ui = new FieldUI();
            var firstplace = gamove.GetPlayerField(PlayerValue.First);
            firstplace.SetCellValue(5, 4, CellValue.Ship);
            firstplace.SetCellValue(8, 1, CellValue.Ship);
            firstplace.SetCellValue(4, 3, CellValue.Ship);
            firstplace.SetCellValue(2, 5, CellValue.Ship);
            firstplace.SetCellValue(1, 9, CellValue.Ship);
            var egg = firstplace.GetCellsValues();

            ui.PrintField(20, 20, egg);

            var firstplace1 = gamove.GetPlayerField(PlayerValue.Second);
            firstplace1.SetCellValue(2, 7, CellValue.Ship);

            var secondplace = gamove.GetOpponentField(PlayerValue.First);            
            var chicken = secondplace.GetCellsValues();
            ui.PrintField(50, 20, chicken);


            Console.ReadKey();

            gamove.PlayerMove(2 ,7, PlayerValue.First);
            secondplace = gamove.GetOpponentField(PlayerValue.Second);
            chicken = secondplace.GetCellsValues();
            ui.PrintField(50, 20, chicken);

            Console.ReadKey();
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
