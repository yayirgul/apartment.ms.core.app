using Microsoft.AspNetCore.Mvc;

namespace ams.web.Components
{
	public class MenuViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return await Task.FromResult(View());
		}
	}
}
