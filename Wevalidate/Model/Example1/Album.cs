using System.Collections.Generic;
using LanguageExt;

namespace ClassLibrary1.Model.Example1
{
    public class Album
    {
        public string Value { get; }

        private Album(string value)
        {
            Value = value;
        }

        public static Either<string, Album> Validate(string input)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(input))
            {
                return "Album cannot be null/empty";
            }

            if (input.Length < 3)
            {
                errors.Add("Album has to be at least 3 character");
            }

            if (errors.Count == 0)
            {
                return new Album(input);
            }

            return string.Join(", ", errors);
        }
    }
}