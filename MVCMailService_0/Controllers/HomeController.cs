using MVCMailService_0.DesignPatterns.SingletonPattern;
using MVCMailService_0.Models.Context;
using MVCMailService_0.Models.Entities;
using MVCMailService_0.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMailService_0.Controllers
{
    public class HomeController : Controller
    {

        MyContext _db;
        public HomeController()
        {
            _db = DBTool.DBInstance;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AppUser appUser)
        {
            MailService.Send(appUser.Email, body: "Hello World :)", subject: ":)");
            ViewBag.Message = "Mail başarılı şekilde gönderilmiştir";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}