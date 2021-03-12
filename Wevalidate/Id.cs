using System;
using LanguageExt;

namespace ClassLibrary1
{
    public class Id
    {
        public Guid Value { get; }

        private Id(Guid value)
        {
            Value = value;
        }

        public static Either<string, Id> Validate(string input)
        {
            Guid valid;
            if (Guid.TryParse(input, out valid))
            {
                return new Id(valid);
            }

            return "Not a valid guid";
        }
    }
}