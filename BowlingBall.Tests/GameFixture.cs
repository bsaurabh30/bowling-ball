using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        [TestMethod]
        public void CanInstanciateGameObjectTest()
        {
            new Game();
        }

        [TestMethod]
        public void CanRollTheBallTest()
        {
            var game = new Game();
            game.Roll(0);
        }

        [TestMethod]
        public void GetTheScoreTest()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
                game.Roll(1);
            Assert.AreEqual(20, game.GetScore());
        }

        [TestMethod]
        public void ThrowingASpareTest()
        {
            var game = new Game();
            game.Throws(new[] { 5, 5, 8, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Assert.AreEqual(32, game.GetScore());


        }
        [TestMethod]
        public void StrikeTest()
        {
            var game = new Game();
            game.Throws(new[] { 10, 8, 8, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Assert.AreEqual(48, game.GetScore());

        }
        [TestMethod]
        public void PerfectGameTesst()
        {
            var game = new Game();
            game.Throws(new[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });
            Assert.AreEqual(300, game.GetScore());
        }
    }
}
