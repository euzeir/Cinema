using CinemaProjectData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaProject.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinema _cinema;
        private readonly ISalaCinematografica _sala;
        private readonly ISpettatore _spettatore;
        private readonly IBiglietto _biglietto;

        public CinemaController(ICinema cinema)
        {
            _cinema = cinema;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}