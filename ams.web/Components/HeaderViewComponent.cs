namespace ams.web.Components
{
    using Microsoft.AspNetCore.Mvc;

    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
