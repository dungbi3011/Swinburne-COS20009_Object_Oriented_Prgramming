using NUnit.Framework;
using Unit_Test;

namespace Tests
{
    [TestFixture()]
    public class CounterTest
    {
        [Test()]
        public void testStartsZero()
        {
            Counter counterTest = new Counter("Zero?");
            Assert.AreEqual(counterTest.Ticks, 0);
        }

        [Test()]
        public void testIncrement()
        {
            Counter counterTest = new Counter("Zero?");
            counterTest.Increment();
            Assert.AreEqual(counterTest.Ticks, 1);
        }

        [Test()]
        public void testIncrementMultiple()
        {
            Counter counterTest = new Counter("Zero?");
            counterTest.Increment();
            counterTest.Increment();
            counterTest.Increment();
            counterTest.Increment();
            Assert.AreEqual(counterTest.Ticks, 4);
        }

        [Test()]
        public void testReset()
        {
            Counter counterTest = new Counter("Zero?");
            counterTest.Increment();
            counterTest.Increment();
            counterTest.Increment();
            counterTest.Reset();
            Assert.AreEqual(counterTest.Ticks, 0);
        }

    }
}
