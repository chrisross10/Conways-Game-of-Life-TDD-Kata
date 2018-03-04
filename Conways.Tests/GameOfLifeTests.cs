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

        [Fact(Skip = "Guiding test")]
        public void It_generates_the_blinker_patter()
        {
            var seed = new List<int[]> { new[] { 1, 0 }, new[] { 1, 1 }, new[] { 1, 2 } };
            var game = new GameOfLife(seed);
            var secondGeneration = game.Next();
            var thirdGeneration = game.Next();
            Assert.Equal(new List<int[]> { new[] { 0, 1 }, new[] { 1, 1 }, new[] { 2, 1 } }, secondGeneration);
            Assert.Equal(new List<int[]> { new[] { 1, 0 }, new[] { 1, 1 }, new[] { 1, 2 } }, thirdGeneration);
        }
    }
}
