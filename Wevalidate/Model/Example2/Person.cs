using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1.Api;
using LanguageExt;

namespace ClassLibrary1.Model.Example2
{
    public class Person
    {
        public Name Name { get; }
        public List<LotteryTicket> LotteryTickets { get; }

        public Person(Name name, List<LotteryTicket> lotteryTickets)
        {
            Name = name ?? throw new ArgumentNullException(nameof(Name));
            LotteryTickets = lotteryTickets ?? throw new ArgumentNullException(nameof(LotteryTickets));
        }

        public static Either<string, Person> Validate(PersonDto personDto)
        {
            var lotteryTicketValidation =
                personDto
                    .LotteryTickets
                    .Map(LotteryTicket.Validate)
                    .Sequence();

         return
                from validName in Name.Validate(personDto.Name)
                from lotteryTickets in lotteryTicketValidation
                select new Person(validName, lotteryTickets.ToList());
        }
    }
}