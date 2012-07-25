using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtDream.Web.Controllers
{
    public class NoticeController : Controller
    {
        //
        // GET: /Notice/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
