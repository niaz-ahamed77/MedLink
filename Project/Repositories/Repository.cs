﻿using Microsoft.EntityFrameworkCore;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MedLinkDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(MedLinkDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IQueryable<T>> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
