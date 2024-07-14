using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Components
{
    [Area("admin")]
    public class BrandViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
