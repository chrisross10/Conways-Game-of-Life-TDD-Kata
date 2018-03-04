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
            return _aliveCells = new List<int[]>();
        }
    }
}