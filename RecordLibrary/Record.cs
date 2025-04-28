namespace RecordLibrary
{
    public class Record
    {
        private string title;
        private string artist;
        private int duration;

        public int Id { get; set; }
        public string Title
        {
            get => title;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Title is null");
                if (value.Length < 1)
                    throw new ArgumentOutOfRangeException("Title must be at least 1 charachter long");
            }
        }
        public string Artist
        {
            get => artist;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Artist is null");
                if (value.Length < 1)
                    throw new ArgumentOutOfRangeException("Artist must be at least 1 charachter long");
                artist = value;
            }
        }
        public int Duration
        {
            get => duration;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Duration must be a positive number");
                if (value > 7200)
                    duration = value;
            }
        }
        public int PublicationYear { get; set; }
    }
}
