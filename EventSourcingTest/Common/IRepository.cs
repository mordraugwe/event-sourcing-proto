using System;

namespace EventSourcingTest
{
    public interface IRepository<T> where T : AggregateRoot, new()
    {
        void Save(AggregateRoot aggregate, int exptectedVersion);
        T GetById(Guid id);
    }
}