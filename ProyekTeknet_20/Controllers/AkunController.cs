using ProyekPasti_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProyekPasti_20.Controllers
{
    public class AkunController : Controller
    {
        VAKSIN_20Entities db = new VAKSIN_20Entities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Akun akun)
        {
            using (VAKSIN_20Entities context = new VAKSIN_20Entities())
            {
                bool IsValidUser = context.Akuns.Any(x => x.username.ToLower() ==
                     akun.username.ToLower() && x.password == akun.password);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(akun.username, false);
                    Response.Write("<script>alert('Anda Login Sebagai')</script>");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    Response.Write("<script>alert('Username atau Pasword anda salah!!')</script>");
                }
                return View();
            }

        }
    }
}