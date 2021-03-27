using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TicketAttachementValidator : AbstractValidator<TicketAttachement>
    {
        public TicketAttachementValidator()
        {
        }
    }
}
