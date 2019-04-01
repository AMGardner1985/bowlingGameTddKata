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
            Assert.AreEqual(0, g.getScore());
        }


        [Test]
        public void AllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.getScore());
        }

        //[Ignore("")]
        [Test]
        public void OneSpare()
        {
            g.roll(5);
            g.roll(5); //spare
            g.roll(3);
            rollMany(17,0);
            Assert.AreEqual(16, g.getScore());
        }
    }   
}