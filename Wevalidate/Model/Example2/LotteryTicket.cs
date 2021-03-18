using System.Collections.Generic;
using LanguageExt;

namespace ClassLibrary1.Model.Example2
{
    public class LotteryTicket
    {
        public int Value { get; }

        private LotteryTicket(int value)
        {
            Value = value;
        }

        public static Either<string, LotteryTicket> Validate(int lotteryNumber)
        {
            List<string> errors = new List<string>();

            if (lotteryNumber > 200 || lotteryNumber < 0)
            {
                errors.Add($"LotteryNumber {lotteryNumber} has to be 0 < value < 200");
            }

            if (errors.Count == 0)
            {
                return new LotteryTicket(lotteryNumber);
            }

            return string.Join(", ", errors);
        }
    }
}