using System;
using System.Collections.Generic;
using Xunit;

namespace Conways.Tests
{
    public class GameOfLifeTests
    {
        [Fact]
        public void It_generates_the_next_iteration_with_an_empty_seed()
        {
            var seed = new List<int[]>();
            var game = new GameOfLife(seed);
            var nextGeneration = game.Next();
            Assert.Equal(new List<int[]>(), nextGeneration);
        }
    }
}
