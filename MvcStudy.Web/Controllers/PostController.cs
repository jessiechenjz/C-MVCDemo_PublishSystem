using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Web.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index(int id)
        {
            //根据传过来的id查找数据库，拿到文章的实体显示出来
            //string name = MvcStudy.Model.ArticleStatic.title;
            MvcStudy.Model.Post postModel = postBLL.GetModel(id);
            ViewData["article"] = postModel;//可以传一个object对象
            return View();
        }

        public ActionResult Publish()
        {
            return View();
        }
        MvcStudy.Business.Post postBLL = new Business.Post();
        public ActionResult DoPublish()
        {
            string title = Request.Form["title"];
            string content = Request.Form["content"];

            //验证数据正确性

            //保存到数据库
            //MvcStudy.Model.ArticleStatic.title = title;
            //MvcStudy.Model.ArticleStatic.content = content;

            //int id = 2;//插入数据库后生成记录的id
            MvcStudy.Model.User user=(MvcStudy.Model.User)Session["name"];
            MvcStudy.Model.Post postModel = new Model.Post();
            postModel.Title = title+user.Name;
            postModel.Content = content;
            postModel.AddTime = DateTime.Now.ToString();

            int id = postBLL.Add(postModel);
            return RedirectToAction("Index", "Post", new { id = id });
        }
    }
}
