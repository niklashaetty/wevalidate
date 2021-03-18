using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ClassLibrary1.Model;
using ClassLibrary1.Model.Example1;
using ClassLibrary1.Model.Example2;

namespace ClassLibrary1.Api
{
    public static class ControllerA
    {
        // Main Method 
        static void Main(string[] args)
        {
            // Example1
            NullAlbum();
            BadArtist();
            Ok();
            
            // Example 2
            Example2_Ok();
        }
        
        public static void NullAlbum()
        {
            Console.WriteLine("\n \n");
            string guid = "43c3ff9a-6fcf-4ae9-959d-fe9ed6c38ab8";
            string artist = "Kent";
            string album = null;
            var dto = new SongDto(guid, artist, album);
            
            Console.WriteLine($"Validating SongDto: {dto}");
            
            var validation = Song.Validate(dto);
            validation.Match(
                Left: error => Console.WriteLine("Error!! " + error),
                Right: ok => Console.WriteLine(ok.ToString()));
        }
        
        public static void BadArtist()
        {
            Console.WriteLine("\n \n");
            string guid = "43c3ff9a-6fcf-4ae9-959d-fe9ed6c38ab8";
            string artist = "12";
            string album = "namee";
            var dto = new SongDto(guid, artist, album);
            
            Console.WriteLine($"Validating SongDto: {dto}");
            
            var validation = Song.Validate(dto);
            validation.Match(
                Left: error => Console.WriteLine("Error!! " + error),
                Right: ok => Console.WriteLine(ok.ToString()));
        }
        
        public static void Ok()
        {
            Console.WriteLine("\n \n");
            string guid = "43c3ff9a-6fcf-4ae9-959d-fe9ed6c38ab8";
            string artist = "Kent";
            string album = "namee";
            var dto = new SongDto(guid, artist, album);
            
            Console.WriteLine($"Validating SongDto: {dto}");
            
            var validation = Song.Validate(dto);
            validation.Match(
                Left: error => Console.WriteLine("Error!! " + error),
                Right: ok => Console.WriteLine("Validation OK!!! \n " + ok));
        }
        
        
        public static void Example2_Ok()
        {
            Console.WriteLine("\n \n");
            string name = "hello";
            List<int> lotterytickets = new List<int> { 1, 2, 500, 6 };
            var dto = new PersonDto(name, lotterytickets);
            
            Console.WriteLine($"Validating SongDto: {dto}");
            
            var validation = Person.Validate(dto);
            validation.Match(
                Left: error => Console.WriteLine("Error!! " + error),
                Right: ok => Console.WriteLine(ok.ToString()));
        }
    }
}