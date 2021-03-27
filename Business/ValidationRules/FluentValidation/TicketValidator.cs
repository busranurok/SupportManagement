using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TicketValidator: AbstractValidator<Ticket>
    {
        public TicketValidator()
        {
        }
    }
}
