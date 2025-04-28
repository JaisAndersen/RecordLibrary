using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLibrary.Models.Tests
{
    [TestClass()]
    public class RecordTests
    {
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
        }

    }
}