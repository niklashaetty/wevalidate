using LanguageExt;

namespace ClassLibrary1
{
    public class Name
    {

        public string Value { get; }

        public Name(string value)
        {
            Value = value;
        }

        public static Either<string, Name> Validate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Name cannot be null/empty";
            }

            if (input.Length < 3)
            {
                return "Name has to be at least 3 characters";
            }

            return new Name(input);
        }
    }
}