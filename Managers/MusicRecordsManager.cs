namespace PairProgramming.Managers
{
    public class MusicRecordsManager
    {
        
        private static int _nextID = 1;
        public static  List<MusicRecords> _musicRecords = new List<MusicRecords>()
        {
             new MusicRecords(_nextID++, "1", "1", "1", 2000),
             new MusicRecords(_nextID++, "2", "2", "2", 2000),
             new MusicRecords(_nextID++, "3", "3", "3", 2000),
             new MusicRecords(_nextID++, "4", "4", "4", 2000),
             new MusicRecords(_nextID++, "4", "4", "4", 2000),
             
        };

        public List<MusicRecords> GetAll()
        {
            return _musicRecords;
        }

        public MusicRecords GetByTitle(string title)
        {

            if( title == null )
            {
                throw new ArgumentNullException("title");
            }

            return _musicRecords.Find(record => record.Title == title);

        }

        public MusicRecords GetByArtist(string artist)
        {
            if(artist == null)
            {
                throw new ArgumentNullException("artist");
            }

            return _musicRecords.Find(record => record.Artist == artist);

        }

        public MusicRecords GetByPublicationYear(int publicationYear)
        {
            if (publicationYear == null)
            {
                throw new ArgumentNullException("publicationYear");
            }

            return _musicRecords.Find(record => record.PublicationYear == publicationYear);

        }

        public MusicRecords GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            return _musicRecords.Find(record => record.Id == id);
        }

        public MusicRecords Delete(int id)
        {
            MusicRecords musicRecords = _musicRecords.Find(musicRecords => musicRecords.Id == id);
            if (musicRecords == null) return null;
            _musicRecords.Remove(musicRecords);
            return musicRecords;
        }

        public MusicRecords Update(int id, MusicRecords records)
        {
            MusicRecords musicRecords = _musicRecords.Find(musicRecords => musicRecords.Id == id);
            if (musicRecords != null) return null;
            musicRecords.Artist = records.Artist;
            musicRecords.Title = records.Title;
            musicRecords.PublicationYear = records.PublicationYear;
            musicRecords.Duration = records.Duration;
            return musicRecords;
        }

        public MusicRecords Add(MusicRecords musicRecords)
        {
            musicRecords.Id = _nextID++;
            _musicRecords.Add(musicRecords);
            return musicRecords;
        }

    }
}
