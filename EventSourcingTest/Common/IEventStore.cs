using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcingTest.Common
{
    public interface IEventStore
    {
        void SaveEvents(Guid aggregateId, IEnumerable<Event> events, int expectedVersion);
        List<Event> GetEventsForAggregate(Guid aggregateId);
    }

}
