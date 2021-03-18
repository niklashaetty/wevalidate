namespace ClassLibrary1.Api
{
    public class SongDto
    {
        public string Artist { get; }
        public string Id { get; }
        public string Album { get; }

        public SongDto(string id, string artist, string album)
        {
            Artist = artist;
            Id = id;
            Album = album;
        }

        public override string ToString()
        {
            return $"\n {nameof(Artist)}: {Artist}, \n {nameof(Id)}: {Id}, \n {nameof(Album)}: {Album}";
        }
    }
}