using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
    [TestFixture()]
    public class FlightTest
    {

        [Test()]
        public void TestFlightInitiates()
        {
            var target = new Flight(System.DateTime.Today, System.DateTime.Parse("10/5/2012"), 100);
            Assert.IsNotNull(target);

        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsErroronBadDate()
        {
            var target = new Flight(System.DateTime.Today, System.DateTime.Parse("10/5/1999"), 100);

        }
        [Test()]
        public void TestThatFlightEqualsWorks()
        {
            var target = new Flight(System.DateTime.Today, System.DateTime.Parse("10/5/2012"), 100);
            var target2 = new Flight(System.DateTime.Today, System.DateTime.Parse("10/5/2012"), 100);
            var target3 = new Flight(System.DateTime.Today, System.DateTime.Parse("10/6/2012"), 100);
            Assert.True(target.Equals(target2));
            Assert.False(target.Equals(target3));
        }
        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsErroronBadMiles()
        {
            var target = new Flight(System.DateTime.Today, System.DateTime.Parse("10/5/2012"), -2);

        }


    }
}
