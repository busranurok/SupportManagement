﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class TicketType : IEntity
    {
        public TicketType()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
