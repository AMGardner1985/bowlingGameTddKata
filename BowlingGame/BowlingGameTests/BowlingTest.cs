using BowlingGame;
using NUnit.Framework;

namespace BowlingTest
{
    public class Tests
    {
        private Game g;

        [SetUp]
        public void Setup()
        {
            g = new Game();
        }


        [Test]
        public void canRoll()
        {
            g.roll(0);
        }

        [Test]
        public void canRoleGutterGame()
        {
            for (int i = 0; i < 20; i++)
                g.roll(0);
            Assert.AreEqual(0, g.getScore());
        }

        [Test]
        public void allOnes()
        {
            for (int i = 0; i < 20; i++)
                g.roll(1);
            Assert.AreEqual(20, g.getScore());
        }
    }   
}