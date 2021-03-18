using System.Collections.Generic;
using ClassLibrary1.Model;

namespace ClassLibrary1.Api
{
    public class PersonDto
    {
        public string Name { get; }
        public List<int> LotteryTickets { get; }

        public PersonDto(string name, List<int> lotteryTickets)
        {
            Name = name;
            LotteryTickets = lotteryTickets;
        }

        public override string ToString()
        {
            return $"Name: {Name}, LotteryTickets: {LotteryTickets}";
        }
    }
}