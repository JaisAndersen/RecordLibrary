using RecordLibrary.Models;

namespace RecordLibrary
{
    public class RecordsRepository
    {
        private List<Record> records = new();
        private int nextId = 1;

        public Record Add(Record record)
        {
            if (record == null) 
            {
                throw new ArgumentNullException("Record is null");
            }
            record.Id = nextId++;
            records.Add(record);
            return record;

        }

        public List<Record> GetRecords()
        {
            var result = new List<Record>(records);
            return result;
        }

    }
}
