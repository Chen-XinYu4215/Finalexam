using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411004215.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Music(string name, string number)
        {

            return View();
        }

    }
}