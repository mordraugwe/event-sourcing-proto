using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace EventSourcingTest.Aggregates
{
    public class PositionAggregate : AggregateRoot
    {
        public static Event[] CreateNewPosition(string jobTitle)
        {
            return new []{ new Event()
            {
                AggregateId = Guid.NewGuid().ToString(),
                Data = new JObject() { "Name" , jobTitle },
                DateAdded = DateTime.Now,
                EffectiveFrom = DateTime.Now,
                EventType = "CreatePosition",
                RevisionNumber = 1
            }};
        }
    }
}
