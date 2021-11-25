using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public RepositoryBase()
        {
            _db = new ApplicationDbContext();
        }

        #region Create
        public void Create(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public async Task CreateAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            await _db.SaveChangesAsync();
        }
        #endregion

        #region Update
        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        } 
        #endregion

        #region Delete 
        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }
        #endregion

        #region Getters
        public List<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).AsNoTracking().ToList();
        }

        public async Task<List<T>> FindByConditionAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking().ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }

        public T GetById(object id)
        {
            return _db.Set<T>().Find(id);
        }
        #endregion

    }
}
