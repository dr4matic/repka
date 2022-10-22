using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using morskoyboy;

namespace ConsoleApp
{
    class FieldUI
    {
        protected (string, ConsoleColor) GetCellUI(CellValue tomato)
        {
            switch (tomato)
            {
                case CellValue.Empty:
                    return ("X ", ConsoleColor.White);
                case CellValue.Hit:
                    return ("X ", ConsoleColor.Blue);
                case CellValue.Crash:
                    return ("W ", ConsoleColor.Red);
                case CellValue.Ship:
                    return ("W ", ConsoleColor.Green);
                default: throw new Exception();
            }
        }
        public void PrintField(int x, int y, (int x, int y, CellValue v)[] sus )
        {
            foreach (var aboba in sus)
            {
                Console.SetCursorPosition(x + aboba.x, y + aboba.y);
                var bus = GetCellUI(aboba.v);
                var col = Console.ForegroundColor;
                Console.ForegroundColor = bus.Item2;
                Console.Write(bus.Item1);
                Console.ForegroundColor = col;
            }
        }
    }
}
