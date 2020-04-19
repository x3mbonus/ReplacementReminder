using ReplacementReminder.Data;
using ReplacementReminder.Repository.Abstract;

namespace ReplacementReminder.Repository.EntityFramework
{
    public class ReplacementHistoryRepository : RepositoryBase<ReplacementHistoryEntry>, IReplacementHistoryRepository
    {
        public ReplacementHistoryRepository(ApplicationDbContext db)
            : base(db, db.ReplacementHistory)
        {
        }
    }
}
