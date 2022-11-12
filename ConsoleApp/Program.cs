
using morskoyboy;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamove = new Game();
            gamove.Start();
            gamove.OnPlayerRetry += Gamove_OnPlayerRetry;
            gamove.OnPlayerMove += Gamove_OnPlayerMove;
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
            secondplace = gamove.GetOpponentField(PlayerValue.First);
            chicken = secondplace.GetCellsValues();
            ui.PrintField(50, 20, chicken);

            Console.ReadKey();

            gamove.PlayerMove(2, 7, PlayerValue.First);

            Console.ReadKey();



        }

        private static void Gamove_OnPlayerMove(CellValue cv, PlayerValue pv)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(string.Join(" ", Enumerable.Range(0, 25).Select(x => "")));
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Игрок {pv} выстрелил с результатом {cv}");
        }

        private static void Gamove_OnPlayerRetry(CellValue cv, PlayerValue pv)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(string.Join(" ", Enumerable.Range(0, 25).Select(x => "")));
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Игрок, ты уже сюда стрелял");
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
