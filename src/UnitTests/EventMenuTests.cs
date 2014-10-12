using System;
using System.Collections.Generic;
using NUnit.Framework;
using _1_Int_EventMenu;

namespace UnitTests
{
    [TestFixture]
    class EventMenuTests
    {
        [Test]
        public void CanCreateEvent()
        {
            Event e = new Event
            {
                ID = 1,
                Date = new DateTime(2014, 10, 1),
                Name = "Fred"
            };

            Assert.IsNotNull(e);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CannotSetZeroDay()
        {
            Event e = new Event
            {
                ID = 1,
                Date = new DateTime(2014, 10, 0),
                Name = "Fred"
            };        
        }

        [Test]
        public void CountIsIncrementedWhenEventAdded()
        {
            EventController.Events = new List<Event>();
            Assert.AreEqual(0, EventController.Events.Count);

            Event e = new Event
            {
                ID = 1,
                Date = new DateTime(2014, 10, 1),
                Name = "Fred"
            };

            Assert.AreEqual(1, EventController.Events.Count);
        }
    }
}
