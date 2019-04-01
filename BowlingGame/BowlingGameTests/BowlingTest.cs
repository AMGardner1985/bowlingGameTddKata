using BowlingGame;
using NUnit.Framework;

namespace BowlingTest
{
    public class Tests
    {
        private Game g;

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.roll(pins);
        }

        private void RollSpare()
        {
            g.roll(5);
            g.roll(5);
        }

        private void RollStrike()
        {
            g.roll(10);
        }

        [SetUp]
        public void Setup()
        {
            g = new Game();
        }


        [Test]
        public void CanRoll()
        {
            g.roll(0);
        }

        [Test]
        public void CanRoleGutterGame()
        {
            rollMany(20, 0);
            Assert.AreEqual(0, g.GetScore());
        }


        [Test]
        public void AllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.GetScore());
        }

        [Test]
        public void OneSpare()
        {
            RollSpare();
            g.roll(3);
            rollMany(17, 0);
            Assert.AreEqual(16, g.GetScore());
        }

        [Test]
        public void OneStrike()
        {
            RollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(16, 0);
            Assert.AreEqual(24, g.GetScore());
        }

        [Test]
        public void PerfectGame()
        {
            rollMany(12, 10);
            Assert.AreEqual(300, g.GetScore());
        }

    }   
}