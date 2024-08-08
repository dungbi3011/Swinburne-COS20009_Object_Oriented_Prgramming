using NUnit.Framework;
using System;
using CounterClock;
using Unit_Test;

namespace Tests
{
    [TestFixture]
    public class ClockTest
    {

        [Test()]
        public void testClockStartsZero()
        {
            Clock counterTest = new Clock();
            Assert.AreEqual(counterTest.ReadTime, "00:00:00");
        }

        //testing whether calling Tick() increments the Seconds
        [Test()]
        public void testClockTicks()
        {
            Clock counterTest = new Clock();
            for (int i = 0; i < 12; i++)
            {
                counterTest.Tick();
            }
            Assert.AreEqual(counterTest.ReadTime, "00:00:12");
        }
        
        [Test()]
        public void testClockMinutes()
        {
            Clock counterTest = new Clock();
            for (int i = 0; i < 60; i++)
            {
                counterTest.Tick();
            }
            Assert.AreEqual(counterTest.ReadTime, "00:01:00");
        }

        [Test()]
        public void testClockHours()
        {
            Clock counterTest = new Clock();
            for (int i = 0; i < 60 * 60; i++)
            {
                counterTest.Tick();
            }

            Assert.AreEqual(counterTest.ReadTime, "01:00:00");
        }

        [Test()]
        public void test24Hours()
        {
            Clock counterTest = new Clock();
            for (int i = 0; i < 60 * 60 * 24 + 1; i++)
            {
                counterTest.Tick();
            }

            Assert.AreEqual(counterTest.ReadTime, "24:00:01");
        }

        [Test()]
        public void testReset()
        {
            Clock counterTest = new Clock();
            for (int i = 0; i < 50; i++)
            {
                counterTest.Tick();
            }
            counterTest.ResetClock();

            Assert.AreEqual(counterTest.ReadTime, "00:00:00");
        }

    }
}
