using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<int[]> LiveNeighbours(int[] cell)
        {
            var liveNeighbours = new List<int[]>();
            //foreach (var neighbour in Neighbours(cell))
            //{
            //    if (_aliveCells.Any(c => c.SequenceEqual(neighbour)))
            //    {
            //        liveNeighbours.Add(neighbour);
            //    }
            //}

            return liveNeighbours;
        }
    }
}