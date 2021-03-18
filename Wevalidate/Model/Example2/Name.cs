using System;
using System.Collections.Generic;
using LanguageExt;

namespace ClassLibrary1.Model.Example2
{
    public class Name
    {
        public string Value { get; }

        private Name(string value)
        {
            Value = value;
        }

        public static Either<string, Name> Validate(string input)
        {

            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(input))
            {
                return "Name cannot be null/empty";
            }

            if (input.Length < 3)
            {
                errors.Add("Name has to be at least 3 characters");
            }
            
            if (errors.Count == 0)
            {
                return new Name(input);
            }

            return String.Join(", ", errors);
        }
    }
}