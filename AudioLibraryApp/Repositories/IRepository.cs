﻿namespace AudioLibraryApp.Repositories;
using AudioLibraryApp.Entities;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    where T: class, IEntity
{
  
}
