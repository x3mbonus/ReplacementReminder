using Microsoft.EntityFrameworkCore;
using ReplacementReminder.Data;
using ReplacementReminder.Repository.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace ReplacementReminder.Repository.EntityFramework
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> _table;

        public RepositoryBase(
            ApplicationDbContext db,
            DbSet<T> table)
        {
            _db = db;
            _table = table;
        }

        public bool Create(T entity)
        {
            _table.Add(entity);
            return Save();
        }

        public bool Delete(T entity)
        {
            _table.Remove(entity);
            return Save();
        }

        public ICollection<T> FindAll()
        {
            return _table.ToList();
        }

        public T FindById(int id)
        {
            return _table.Find(id);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {

            _table.Update(entity);
            return Save();
        }
    }
}
