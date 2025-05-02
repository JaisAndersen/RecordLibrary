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
            repo.Add(new Record(1, "Test Album", "Test Artist", 120, 2023));
            repo.Add(new Record(2, "Another Album", "Another Artist", 121, 2022));
            repo.Add(new Record(3, "Third Album", "Third Artist", 122, 2021));
            repo.Add(new Record(4, "Fourth Album", "Fourth Artist", 123, 2020));
            List<Record> records = repo.GetRecords();
            Assert.AreEqual(4, records.Count);
        }
    }
}