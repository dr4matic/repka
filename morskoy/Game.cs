using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    public class Game
    {
        public delegate void PlayerEvent(CellValue cv, PlayerValue pv);
        private Field firstmap = new Field();
        private Field secondmap = new Field();
        private IEnumerator<PlayerValue> _turns = GameTurns().GetEnumerator();
        public event PlayerEvent OnPlayerMove;
        public event PlayerEvent OnPlayerRetry;

        public PlayerValue Current => _turns.Current;

        public Game()
        {
            OnPlayerMove += Game_OnPlayerMove;
        }

        public void Start()
        {
            _turns.MoveNext();
        }


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
            var oldznach = field.GetCellsValue(x, y);
            if (oldznach == CellValue.Crash || oldznach == CellValue.Hit)
            {
                OnPlayerRetry?.Invoke(oldznach, pv);
                return;
            }

            var result = field.CrashValue(x, y);

            OnPlayerMove?.Invoke(result, pv);
        }
        private static IEnumerable<PlayerValue> GameTurns()
        {
            while (true)
            {
                yield return PlayerValue.First;
                yield return PlayerValue.Second;
            }
        }

        private void Game_OnPlayerMove(CellValue cv, PlayerValue pv)
        {
            if (cv != CellValue.Crash)
            {
                _turns.MoveNext();
            }
        }
        
    }
}
