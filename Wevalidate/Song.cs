namespace ClassLibrary1
{
    public class Song
    {
        public Id id { get; }
        public Name name { get; }

        public Song(Id id, Name name)
        {
            this.id = id;
            this.name = name;
        }
    }
}