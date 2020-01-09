using System;
using Newtonsoft.Json.Linq;

namespace EventSourcingTest
{
    public class Event : IMessage
    {
        public string AggregateId { get; set; }
        public JObject Data { get; set; }
        public string EventType { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public int RevisionNumber { get; set; }
    }
}