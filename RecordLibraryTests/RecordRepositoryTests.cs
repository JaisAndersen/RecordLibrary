using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordLibrary;
using RecordLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLibrary.Tests
{
    [TestClass()]
    public class RecordRepositoryTests
    {
        [TestMethod()]
        public void GetRecordsTest()
        {
            RecordsRepository repo = new RecordsRepository();
            repo.Add(new Record("Test Artist", "Test Album", 2023, "Test Genre"));
            repo.Add(new Record("Another Artist", "Another Album", 2022, "Another Genre"));
            repo.Add(new Record("Third Artist", "Third Album", 2021, "Third Genre"));
            repo.Add(new Record("Fourth Artist", "Fourth Album", 2020, "Fourth Genre"));
            List<Record> records = repo.GetRecords();
            Assert.AreEqual(4, records.Count);
        }
    }
}