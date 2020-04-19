using Microsoft.AspNetCore.Mvc;
using ReplacementReminder.Services.Abstract;

namespace ReplacementReminder.Controllers
{
    public class ReplacementItemsListViewComponent : ViewComponent
    {
        private readonly IReplacementItemsService _replacementItemsService;

        public ReplacementItemsListViewComponent(
            IReplacementItemsService replacementItemsService)
        {
            _replacementItemsService = replacementItemsService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _replacementItemsService.FindAll();
            return View("", model);
        }
    }
}
