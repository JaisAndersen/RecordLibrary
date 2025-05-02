using RecordLibrary.Models;

namespace RecordLibrary
{
    public class RecordRepository
    {
        private List<Record> records = new();

        public List<Record> GetRecords()
        {
            var result = new List<Record>(records);
            return result;
        }

    }
}
