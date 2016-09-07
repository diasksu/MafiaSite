using MafiaDomain;
using MafiaDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MafiaSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Header = "Главная страница";
            return View();
        }
        [HttpGet]
        public ActionResult Static(String id)
        {
            MafiaContext context = new MafiaContext();
            StaticPage stP = context.StaticPages.FirstOrDefault(p => p.Name == id);
            if (stP != null)
            {
                ViewBag.Header = stP.Header;
            }
            return View(stP);
        }
        [HttpPost]
        public void Save(String id)
        {
            String htmlCont = Request["file"];
            htmlCont = Server.HtmlDecode(htmlCont);
            MafiaContext context = new MafiaContext();
            StaticPage stPage = context.StaticPages.FirstOrDefault(p => p.Name == id);
            if (stPage != null)
            {
                stPage.Content = htmlCont;
                context.SaveChanges();
            }
        }
    }
}