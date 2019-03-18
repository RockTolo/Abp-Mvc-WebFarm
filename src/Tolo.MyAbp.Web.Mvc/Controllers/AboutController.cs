using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Tolo.MyAbp.Controllers;

namespace Tolo.MyAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MyAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
