﻿namespace UnitOfWork
{
    public interface ITransaction : IDisposable
    {
        Task CommitAsync();
        Task RollbackAsync();
    }
}
