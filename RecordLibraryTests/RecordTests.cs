using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLibraryTests
{
    [TestClass()]
    public class RecordTests
    {
        [TestMethod()]
        public void RecordTitleTest()
        {
            Record record = new Record();
            record.Title = "Test Title";
            Assert.AreEqual("Test Title", record.Title);
            Assert.ThrowsException<ArgumentNullException>(() => record.Title = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Title = "");

        }

        [TestMethod()]
        public void RecordArtistTest()
        {
            Record record = new Record();
            record.Artist = "Test Artist";
            Assert.AreEqual("Test Artist", record.Artist);
            Assert.ThrowsException<ArgumentNullException>(() => record.Artist = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Artist = "");
        }

        [TestMethod()]
        public void RecordDurationTest()
        {
            Record record = new Record();
            record.Duration = 300;
            Assert.AreEqual(300, record.Duration);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Duration = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Duration = 8000);
        }


        [TestMethod()]
        public void ToStringTest()
        {
            Record record = new Record
            {
                Id = 1,
                Title = "Test Title",
                Artist = "Test Artist",
                Duration = 300,
                PublicationYear = 2023
            };
            string result = record.ToString();
            Assert.AreEqual("Id: 1, Title: Test Title, Artist: Test Artist, Duration: 300, PublicationYear: 2023", result);
        }
    }
}