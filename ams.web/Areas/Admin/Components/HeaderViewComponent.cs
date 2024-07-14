using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Components
{
    [Area("admin")]
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
