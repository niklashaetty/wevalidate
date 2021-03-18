using System;
using ClassLibrary1.Api;
using LanguageExt;

namespace ClassLibrary1.Model.Example1
{
    public class Song
    {
        public Id Id { get; }
        public Artist Artist { get; }
        public Album Album { get; }

        public Song(Id id, Artist artist, Album album)
        {
            Id = id ?? throw new ArgumentNullException(nameof(Id));
            Artist = artist ?? throw new ArgumentNullException(nameof(Artist));
            Album = album ?? throw new ArgumentNullException(nameof(Album));
        }

        public static Either<string, Song> Validate(SongDto songDto)
        {
            return
                from validId in Id.Validate(songDto.Id)
                from validArtist in Artist.Validate(songDto.Artist)
                from validAlbum in Album.Validate(songDto.Album)
                select new Song(validId, validArtist, validAlbum);
        }

        public override string ToString()
        {
            return $"Id: {Id.Value}, Artist: {Artist.Value}, Album: {Album.Value}";
        }
    }
}