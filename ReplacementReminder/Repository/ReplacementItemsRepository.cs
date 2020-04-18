using Microsoft.EntityFrameworkCore;
using ReplacementReminder.Abstract;
using ReplacementReminder.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplacementReminder.Repository
{
    public class ReplacementItemsRepository : IReplacementItemsRepository
    {
        private readonly ApplicationDbContext _db;

        public ReplacementItemsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(ReplacementItem entity)
        {
            _db.ReplacementItems.Add(entity);
            return Save();
        }

        public bool Delete(ReplacementItem entity)
        {
            _db.ReplacementItems.Remove(entity);
            return Save();
        }

        public ICollection<ReplacementItem> FindAll()
        {
            return _db.ReplacementItems.ToList();
        }

        public ReplacementItem FindById(int id)
        {
            return _db.ReplacementItems.Find(id);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(ReplacementItem entity)
        {

            _db.ReplacementItems.Update(entity);
            return Save();
        }
    }
}
