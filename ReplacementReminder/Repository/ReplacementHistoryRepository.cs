using Microsoft.EntityFrameworkCore;
using ReplacementReminder.Abstract;
using ReplacementReminder.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplacementReminder.Repository
{
    public class ReplacementHistoryRepository : IReplacementHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public ReplacementHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(ReplacementHistoryEntry entity)
        {
            _db.ReplacementHistory.Add(entity);
            return Save();
        }

        public bool Delete(ReplacementHistoryEntry entity)
        {
            _db.ReplacementHistory.Remove(entity);
            return Save();
        }

        public ICollection<ReplacementHistoryEntry> FindAll()
        {
            return _db.ReplacementHistory.ToList();
        }

        public ReplacementHistoryEntry FindById(int id)
        {
            return _db.ReplacementHistory.Find(id);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(ReplacementHistoryEntry entity)
        {

            _db.ReplacementHistory.Update(entity);
            return Save();
        }
    }
}
