﻿using Livros.Domain.Core;
using Livros.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Livros.Infra.Data.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly SqlServerContext _context;

    public BaseRepository(SqlServerContext context)
      => _context = context;

    public virtual void Create(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Added;
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public virtual void Delete(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public void Dispose()
       => _context.Dispose();

    public virtual List<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public virtual TEntity GetById(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }
}