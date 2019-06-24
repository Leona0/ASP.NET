using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    public class MessageController : Controller
    {
        messageDBService data = new messageDBService();


        // GET: Message
        public ActionResult Index()
        {
            return View(data.GetData());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Article_title, string Content)
        {
            data.DBCrate(Article_title, Content);
            //導向指定的Action
            return RedirectToAction("Index");
        }
    }
}