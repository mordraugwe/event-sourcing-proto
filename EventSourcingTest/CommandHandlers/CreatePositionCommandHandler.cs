using System;
using System.Collections.Generic;
using System.Text;
using EventSourcingTest.Aggregates;
using EventSourcingTest.Commands.Position;

namespace EventSourcingTest.CommandHandlers
{
    public class CreatePositionCommandHandler : ICommandHandler<CreatePositionCommand>
    {
        public CreatePositionCommandHandler(IRepository<PositionAggregate> positionsRepository)
        {
            
        }


        public void Handle(CreatePositionCommand command)
        {
            var newPositionEvent = PositionAggregate.CreateNewPosition(command.JobTitle);
        }
    }
}
