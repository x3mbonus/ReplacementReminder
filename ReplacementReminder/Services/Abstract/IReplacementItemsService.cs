using ReplacementReminder.Models;
using System.Collections.Generic;

namespace ReplacementReminder.Services.Abstract
{
    public interface IReplacementItemsService
    {
        List<ReplacementItemModel> FindAll();
        ReplacementItemModel FindById(int id);
        bool Create(ReplacementItemModel model);
        bool Update(int id, ReplacementItemModel model);
        bool Delete(int id);
    }
}
