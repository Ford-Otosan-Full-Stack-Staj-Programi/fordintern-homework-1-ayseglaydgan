using System;


namespace NiceAPI.DataLayer
{
    public interface IUnitOfWork : IDisposable 
    {
        IGenericRepository<Account> AccountRepository { get; }

        void Complete();
        void CompleteWithTransaction();
    }
}
