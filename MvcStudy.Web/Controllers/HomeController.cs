using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStudy.Web.Controllers.Fliters;

namespace MvcStudy.Web.Controllers
{
    public class HomeController : Controller
    {
        MvcStudy.Business.Post postBLL = new Business.Post();
        //
        // GET: /Home/
        [LoggerFilter]
        public ActionResult Index()
        {
            IList<MvcStudy.Model.Post> allPosts = postBLL.GetModelList("");
            ViewData["allPost"] = allPosts;
            return View();
        }

    }
}
