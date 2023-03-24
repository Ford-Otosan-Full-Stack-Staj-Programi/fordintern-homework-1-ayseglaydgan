using System;


namespace NiceAPI.DataLayer
{
    public interface IUnitOfWork : IDisposable 
    {
        IGenericRepository<Person> PersonRepository { get; }

        void Complete();
        void CompleteWithTransaction();
    }
}
