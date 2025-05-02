using RecordLibrary.Models;

namespace RecordLibrary
{
    public class RecordRepository
    {
        private List<Record> records = new();

        public List<Record> GetRecords()
        {
            List<Record> result = new List<Record>(records);
            return result;
        }

    }
}
