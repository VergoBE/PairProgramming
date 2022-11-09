namespace PairProgramming
{
    public class MusicRecords
    {
        public MusicRecords(int id, string artist, string title, string duration, int publicationYear)
        {
            Id = id;
            Artist = artist;
            Title = title;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public MusicRecords()
        {

        }

        public string Artist { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public int PublicationYear { get; set; }

        public int Id { get; set; }

    }
}