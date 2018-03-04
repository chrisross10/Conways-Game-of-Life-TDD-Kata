using System.Collections.Generic;

namespace Conways
{
    public class GameOfLife
    {
        private readonly List<int[]> _aliveCells;

        public GameOfLife(List<int[]> seed)
        {
            _aliveCells = seed;
        }

        public IEnumerable<int[]> AliveCells => _aliveCells;

        public IEnumerable<int[]> Tick()
        {
            return new List<int[]>();
        }
    }
}