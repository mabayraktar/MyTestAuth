using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using MVCAuthTest.Models;

namespace MVCAuthTest.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        List<UserModel> lUser;
        public AccountController() { 
        lUser = new List<UserModel>();
        lUser.Add(new UserModel(0,"Ahmet","123456","A"));
        lUser.Add(new UserModel(1,"Mehmet","123456","A"));
        lUser.Add(new UserModel(2,"Ali","123456","V"));
        lUser.Add(new UserModel(3,"Derya","123456","V"));
        lUser.Add(new UserModel(4,"Hilal","123456","V"));
        }
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            foreach (var u in lUser)  
            {
                if ((collection.Get("Name") == u.Name) && (collection.Get("Password") == u.Password))
                {
                    FormsAuthentication.SetAuthCookie(u.Name, false);
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.Msg = "Invalid User";
            return View();
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
