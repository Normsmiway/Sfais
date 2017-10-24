using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sfais.Web.Controllers
{
    
    public class AppController : Controller
    {
        
        [Route("")]
        public ActionResult Home()
        {
            return View();
        }

       
        public ActionResult Dashboard()
        {
            return View();
        }

        
        public ActionResult Signup()
        {
            return View();
        }

    }
}