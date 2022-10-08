using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    public class Game
    {
        private Field firstmap = new Field();
        private Field secondmap = new Field();

        public Field GetPlayerField( PlayerValue player)
        {
            if (player == PlayerValue.First)
            {
                return firstmap;
            }
            return secondmap;
        }
        public Field GetOpponentField( PlayerValue opponent)
        {
            var field = opponent == PlayerValue.First
                ? secondmap
                : firstmap;
            var exceptionmap = new Field();

        }
    }
}
