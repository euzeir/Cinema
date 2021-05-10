using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Models
{
    public class SalaCinematografica
    {
        public int IdSala { get; set; }
        public int MassimoNumeroDiSpettatori { get; set; }
        public List<Spettatore> Spettatori { get; set; }
        public Film FilmInProiezione { get; set; }
    }
}
