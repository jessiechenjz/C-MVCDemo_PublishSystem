using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()//这就是一个Action
        {
            return View();
        }
        public ActionResult Login()//这就是一个Action
        {
            return View();
        }

        public ActionResult DoLogin()
        {
            string name = Request.Form["name"];
            string password = Request.Form["password"];
            string password2 = Request.Form["password2"];

            int res = 1;

            IList<MvcStudy.Model.User> userList = userBLL.GetModelList(" name='" + name + "' and password='" + password + "'");

            if (userList.Count != 1)
            {
                res = 0;
                
            }
            else
            {
                Session["name"] = userList[0];//登录成功
            }

            return Content(res.ToString());
        }

        public ActionResult Register()
        {
            return View();
        }

        MvcStudy.Business.User userBLL = new Business.User();

        public ActionResult DoRegister()
        {
            string name = Request.Form["name"];
            string password = Request.Form["password"];
            string password2 = Request.Form["password2"];
            string code = Request.Form["code"];

            int res = 0;
            if (code != Session["Code"])
            {
                res = -1;
            }
            else
            { 
                //插入数据库
                MvcStudy.Model.User userModel = new Model.User();
                userModel.AddTime = DateTime.Now.ToString();
                userModel.Name = name;
                userModel.Password = password;

                res = userBLL.Add(userModel);

            }
            return Content(res.ToString());
        }

        public ActionResult LogOff()
        {
            Session["name"] = null;
            Session.Clear();
            Session.RemoveAll();
            return new RedirectResult("/Home/Index");
        }
    }
}
