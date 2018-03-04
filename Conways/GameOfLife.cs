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
            return Neighbours(cell)
                .Where(neighbour => _aliveCells.Any(c => c.SequenceEqual(neighbour)))
                .ToList();
        }

        public IEnumerable<int[]> Neighbours(int[] cell)
        {
            var deltas = new List<int[]>
            {
                new[] {-1, -1},
                new[] {0, -1},
                new[] {1, -1},
                new[] {-1, 0},
                new[] {1, 0},
                new[] {-1, 1},
                new[] {0, 1},
                new[] {1, 1}
            };

            var neighbours = new List<int[]>();
            foreach (var delta in deltas)
            {
                var x = cell[0] + delta[0];
                var y = cell[1] + delta[1];
                neighbours.Add(new[] { x, y });
            }

            return neighbours;
        }
    }
}