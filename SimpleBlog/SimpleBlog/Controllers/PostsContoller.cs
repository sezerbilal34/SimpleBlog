using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SimpleBlog.Controllers
{
    public class PostsContoller:Controller
    {
        public ActionResult Index()
        {
            return Content("Hello World");
        }
    }
}