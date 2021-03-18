using System;
using System.Collections.Generic;
using LanguageExt;

namespace ClassLibrary1.Model.Example1
{
    public class Artist
    {
        public string Value { get; }

        private Artist(string value)
        {
            Value = value;
        }

        public static Either<string, Artist> Validate(string input)
        {

            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(input))
            {
                return "Artist cannot be null/empty";
            }

            if (input.Length < 3)
            {
                errors.Add("Artist has to be at least 3 characters");
            }

            if (input != "Kent")
            {
                errors.Add("You need to pick a better artist");
            }

            if (errors.Count == 0)
            {
                return new Artist(input);
            }

            return String.Join(", ", errors);
        }
    }
}