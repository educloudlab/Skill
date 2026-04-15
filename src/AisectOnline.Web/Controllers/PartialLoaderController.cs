using AisectOnline.Services.Modules.Common;
using Microsoft.AspNetCore.Mvc;

namespace AisectOnline.Web.Controllers
{
    public class PartialLoaderController : Controller
    {
        private readonly ICommonService _commonService;
        public PartialLoaderController(ICommonService commonService)
        {
            _commonService = commonService;
        }
        public async Task<IActionResult> LoadPartial(string viewName)
        {
            // Extract the controller name (e.g., "Student" from "_StudentIndex")
            var controllerName = viewName.Replace("_", "").Replace("Index", "");

            // Call your menu loading logic dynamically
            int UserID = (int)HttpContext.Session.GetInt32("AISECTUSERID");
            var menus = await _commonService.GetMenusAsync(controllerName,UserID);

            return PartialView($"~/Views/Shared/Partials/{viewName}.cshtml", menus);
        }
    }
}
