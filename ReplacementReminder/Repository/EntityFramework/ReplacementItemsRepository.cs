using ReplacementReminder.Data;
using ReplacementReminder.Repository.Abstract;

namespace ReplacementReminder.Repository.EntityFramework
{
    public class ReplacementItemsRepository : RepositoryBase<ReplacementItem>, IReplacementItemsRepository
    {
        public ReplacementItemsRepository(ApplicationDbContext db)
            : base(db, db.ReplacementItems)
        {
        }
    }
}
