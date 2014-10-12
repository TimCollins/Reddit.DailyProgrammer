using System;
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
    }
}
