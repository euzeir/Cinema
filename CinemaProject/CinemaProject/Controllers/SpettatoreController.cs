using CinemaProjectData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaProject.Controllers
{
    [RoutePrefix("Spettatore/Index/")]
    public class SpettatoreController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id)
        {
            CinemaManagement mng = new CinemaManagement();
            mng.Minore(id);
            mng.Maggiore(id);
            return View(mng);
        }
    }
}