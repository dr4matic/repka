using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    public class Game
    {
        private Field firstmap = new Field();
        private Field secondmap = new Field();
        private IEnumerator<PlayerValue> _turns = GameTurns().GetEnumerator();

        public Field GetPlayerField(PlayerValue player)
        {
            if (player == PlayerValue.First)
            {
                return firstmap;
            }
            return secondmap;
        }
        public Field GetOpponentField(PlayerValue opponent)
        {
            var field = opponent == PlayerValue.First
                ? secondmap
                : firstmap;
            var exceptionmap = new Field();
            var cells = field.GetCellsValues();
            foreach (var znach in cells)
            {
                var res = znach.v == CellValue.Ship ? CellValue.Empty : znach.v;
                exceptionmap.SetCellValue(znach.x, znach.y, res);
            }

            return exceptionmap;
        }
        public void PlayerMove(byte x, byte y, PlayerValue pv)
        {
            if (pv != _turns.Current)
            {
                return;
            }
            var field = GetPlayerField(pv == PlayerValue.First ? PlayerValue.Second : PlayerValue.First);
            field.CrashValue(x, y);
        }
        private static IEnumerable<PlayerValue> GameTurns()
        {
            while (true)
            {
                yield return PlayerValue.First;
                yield return PlayerValue.Second;
            }
        }
        public void Start()
        {
            _turns.MoveNext();
        }
    }
}
