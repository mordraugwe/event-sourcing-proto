using System;
using System.Collections.Generic;
using System.Text;
using EventSourcingTest.Aggregates;
using EventSourcingTest.Commands.Position;

namespace EventSourcingTest.CommandHandlers
{
    public class CreatePositionCommandHandler : ICommandHandler<CreatePositionCommand>
    {
        private readonly IRepository<PositionAggregate> _positionsRepository;

        public CreatePositionCommandHandler(IRepository<PositionAggregate> positionsRepository)
        {
            _positionsRepository = positionsRepository;
        }


        public void Handle(CreatePositionCommand command)
        {
            var position = new PositionAggregate(command.PositionId, command.JobTitle);
            position.AssignToDepartment(command.UnitId);

            _positionsRepository.Save(position, 100);
        }
    }
}
