using System;
using NUnit.Framework;
using _12_Beep;

namespace UnitTests
{
    [TestFixture]
    public class _12_NoteTests
    {
        private NotePlayer _player;

        [SetUp]
        public void Setup()
        {
            _player = new NotePlayer();    
        }

        [Test]
        public void UnsupportedNotesShouldThrowException()
        {
            string[] input = {"Z"};

            Assert.Throws<ApplicationException>(() => _player.Play(input));
        }

        // These tests work but they slow down the test runner and are noisy so I'm excluding them
        // for now
        //[Test]
        //public void SupportedNotesShouldNotThrowException()
        //{
        //    string[] input = { "a", "b", "c", "d", "e", "f", "g" };

        //    _player.Play(input);
        //}

        //[Test]
        //public void NoteCaseDoesNotAffectOutput()
        //{
        //    string[] input = { "A", "B", "C", "D", "E", "F", "G" };

        //    _player.Play(input);
        //}
    }
}
