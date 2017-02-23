using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        
        public ActionResult Index()
        {
            return Content("Users!");
        }
        public ActionResult List()
        {
            return Content("List!");
        }
        public ActionResult Edit(int id=0)
        {
            return Content("Edit!"+ id);
        }
    }
}