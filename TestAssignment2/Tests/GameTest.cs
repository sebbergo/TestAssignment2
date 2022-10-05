using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment2.Classes;

namespace TestAssignment2.Tests
{
    internal class GameTest
    {
        private Game g;

        [SetUp]
        public void SetUp()
        {
            g = new Game();
        }

        private void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }

        private void rollSpare()
        {
            g.Roll(6);
            g.Roll(4);
        }

        [Test]
        public void TestGameClass()
        {
            Assert.That(g, Is.TypeOf(typeof(Game)));
        }

        [Test]
        public void TestGutterGame()
        {
            rollMany(20, 0);

            Assert.That(g.Score, Is.EqualTo(0));
        }

        [Test]
        public void TestAllOnes()
        {
            rollMany(20, 1);

            Assert.That(g.Score, Is.EqualTo(20));
        }

        [Test]
        public void TestOneSpare()
        {
            rollSpare();
            g.Roll(4);
            rollMany(17, 0);
            Assert.That(g.Score, Is.EqualTo(18));
        }

        [Test]
        public void TestOneStrike()
        {
            g.Roll(10);
            g.Roll(4);
            g.Roll(5);
            rollMany(17, 0);

            Assert.That(g.Score, Is.EqualTo(28));
        }

        [Test]
        public void TestPerfectGame()
        {
            rollMany(12, 10);

            Assert.That(g.Score, Is.EqualTo(300));
        }

        [Test]
        public void TestRandomGameNoExtraRoll()
        {
            g.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 });

            Assert.That(g.Score, Is.EqualTo(131));
        }

        [Test]
        public void TestRandomGameWithSpareThenStrikeAtEnd()
        {
            g.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 1, 10 });

            Assert.That(g.Score, Is.EqualTo(143));
        }

        [Test]
        public void TestRandomGameWithThreeStrikesAtEnd()
        {
            g.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 10, 10, 10 });

            Assert.That(g.Score, Is.EqualTo(163));
        }
    }
}
