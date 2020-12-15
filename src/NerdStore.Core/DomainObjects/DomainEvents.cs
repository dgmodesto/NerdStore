using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects
{
    public class DomainEvents : Event
    {
        public DomainEvents(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
