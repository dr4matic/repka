using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    public class Field
    {
        private byte[,] cells;
        public byte GetCellsValue(byte x, byte y)
        {
            return cells[x, y];
        }
        public bool SetCellValue(byte x, byte y, byte value)
        {
            if (cells[x, y] != 0)
            {
               return false;
            }
            cells[x, y] = value;
            return true;
        }
        public Field(int sizex, int sizey)
        {
            cells = new byte[sizex, sizey];
        }
        public Field(int sizex) : this(sizex, sizex)
        {

        }
        public Field() : this(10)
        {

        }
        public bool CrashValue(byte x, byte y)
        {
            if (cells[x,y] == 0)
            {
                return false;
            }
            return true;
        }
        
    }
}
