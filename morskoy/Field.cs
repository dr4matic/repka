using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    public class Field
    {
        private CellValue[,] cells;
        public CellValue GetCellsValue(byte x, byte y)
        {
            return cells[x, y];
        }
        public bool SetCellValue(int x, int y, CellValue value)
        {
            if (cells[x, y] != CellValue.Empty)
            {
               return false;
            }
            cells[x, y] = value;
            return true;
        }
        public Field(int sizex, int sizey)
        {
            cells = new CellValue[sizex, sizey];
        }
        public Field(int sizex) : this(sizex, sizex)
        {

        }
        public Field() : this(10)
        {

        }
        public CellValue CrashValue(byte x, byte y)
        {
            if (cells[x,y] == CellValue.Ship)
            {
                cells[x, y] = CellValue.Crash;
            }
            if (cells[x,y] == CellValue.Empty)
            {
                cells[x, y] = CellValue.Hit;                
            }
            
            return cells[x, y];
        }
            
        public (int x, int y, CellValue v)[] GetCellsValues()
        {
            var rezult = new List<(int x, int y, CellValue)>();
            for (var j = 0; j < cells.GetLength(1); j++)
            {
                for (var i = 0; i < cells.GetLength(0); i++)
                    
                {
                    rezult.Add((i,j, cells[i,j]));
                }
            }
            return rezult.ToArray();
        }
        
        
    }
}
