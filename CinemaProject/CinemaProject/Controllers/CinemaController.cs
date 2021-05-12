﻿using CinemaProjectData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaProject.Controllers
{
    [RoutePrefix("Cinema/Index")]
    public class CinemaController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id)
        {
            CinemaManagement mng = new CinemaManagement();
            mng.IncassoCinema();
            mng.CalcolareIncassoSala(id);
            return View(mng);
        }

        [HttpGet]
        public ActionResult Sconto(int id)
        {
            CinemaManagement mng = new CinemaManagement();
            mng.ScontoAnziani(id);
            return View(mng);
        }
    }
}