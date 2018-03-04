using System.Collections.Generic;

namespace Conways
{
    public class GameOfLife
    {
        private List<int[]> _aliveCells;

        public GameOfLife(List<int[]> seed)
        {
            _aliveCells = seed;
        }

        public IEnumerable<int[]> AliveCells => _aliveCells;

        public IEnumerable<int[]> Tick()
        {
            var survivors = new List<int[]>();
            //foreach (var cell in _aliveCells)
            //{
            //    if (LiveNeighbours(cell).Count() == 2 || LiveNeighbours(cell).Count() == 3)
            //    {
            //        survivors.Add(cell);
            //    }
            //}

            _aliveCells = survivors;
            return _aliveCells;
        }
    }
}