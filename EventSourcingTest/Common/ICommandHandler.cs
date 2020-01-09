namespace EventSourcingTest
{
    public interface ICommandHandler<TCommand> where TCommand : IMessage
    {
        void Handle(TCommand message);
    }
}