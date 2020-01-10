using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace EventSourcingTest.Aggregates
{
    public class PositionAggregate : AggregateRoot
    {
        private string _id;

        public PositionAggregate()
        {
            
        }

        public PositionAggregate(string id, string jobTitle)
        {
            ApplyChange(new Event(){AggregateId = id, RevisionNumber = -1, Data = JObject.FromObject(new {Id = id, JobTitle = jobTitle})});
        }

        public void AssignToDepartment(string departmentId)
        {
            ApplyChange(new Event(){AggregateId = Id, Data = JObject.FromObject(new { UnitId = departmentId })});
        }
    }
}
