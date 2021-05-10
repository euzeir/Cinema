using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public interface IStatistiche
    {
        decimal GenerePreferito();
        string FilmConMaggiorNumeroDiSpettatori();
        string FilmConMinorNumeroDiSpettatori();
    }
}
