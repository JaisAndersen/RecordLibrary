using System.Xml.Linq;

namespace RecordLibrary.Models
{
    public class Record
    {
        private string title;
        private string artist;
        private int duration;
        private int publicationYear;

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
                title = value;
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
                    throw new ArgumentOutOfRangeException("Duration must be less than 7200 seconds");
                duration = value;
            }
        }
        public int PublicationYear 
        { 
            get => publicationYear; 
            set 
            {
                if (value < 1900)
                    throw new ArgumentOutOfRangeException("Publication year must be greater than 1900");
                publicationYear = value;
            }
                
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Artist: {Artist}, Duration: {Duration}, PublicationYear: {PublicationYear}";
        }
    }
}
