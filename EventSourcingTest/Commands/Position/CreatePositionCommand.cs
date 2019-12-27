using System;

namespace EventSourcingTest.Commands.Position
{
    public class CreatePositionCommand : Command
    {
        public string PositionId { get; }
        public string UnitId { get; }
        public string JobTitle { get; }

        public CreatePositionCommand(string positionId, string unitId, string jobTitle)
        {
            PositionId = positionId;
            UnitId = unitId;
            JobTitle = jobTitle;
        }
    }
}
