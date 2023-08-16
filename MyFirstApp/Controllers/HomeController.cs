using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Content()
        {
            ViewBag.imgPath = "https://res.cloudinary.com/daily-now/image/upload/f_auto,q_auto/v1/posts/b601cf176f9f29afd0b7e288b106e137?_a=AQADKdt";
            ViewBag.content = "That is Home";

            return View();
        }

        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return TimeString();
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }
    }
}