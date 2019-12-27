using System;
using System.Collections.Generic;
using System.Text;
using EventSourcingTest.Commands.Position;

namespace EventSourcingTest.CommandHandlers
{
    public class CreatePositionCommandHandler : ICommandHandler<CreatePositionCommand>
    {
        public void Handle(CreatePositionCommand command)
        {

        }
    }
}
