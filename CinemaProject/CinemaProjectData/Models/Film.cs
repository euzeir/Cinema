using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Models
{
    public class Film
    {
        public int IdFilm { get; set; }
        public string TitoloFilm { get; set; }
        public string AutoreFilm { get; set; }
        public string ProduttoreFilm { get; set; }
        public string GenereFilm { get; set; }
        public decimal DurataFilm { get; set; }
    }
}
