using MafiaDomain;
using MafiaDomain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MafiaSite.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            ViewBag.Header = "Мероприятия";
            MafiaContext context = new MafiaContext();
            return View(context.Events);
        }
        public ActionResult Item(int id)
        {
            ViewBag.Header = "Мероприятия";
            MafiaContext context = new MafiaContext();
            Event evt = context.Events.Find(id);
            context.Entry(evt).Collection(x => x.EventPhotos).Load();
            return View(evt);
        }
        [HttpPost]
        public void ImagesUpload(int id)
        {
            MafiaContext context = new MafiaContext();
            Event evt = context.Events.Find(id);
            if (!string.IsNullOrEmpty(Request.Headers["X-File-Name"]))
            {
                String serverPath = string.Format("/Uploads/{0}", Request.Headers["X-File-Name"]);
                string path = Server.MapPath(serverPath);
                Stream inputStream = Request.InputStream;
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    inputStream.CopyTo(fileStream);
                    fileStream.Close();
                }
                EventPhoto evtPh = new EventPhoto()
                {
                    ParentEvent = evt,
                    Path = serverPath
                };
                context.EventPhotos.Add(evtPh);
                context.SaveChanges();
            }
        }
    }
}