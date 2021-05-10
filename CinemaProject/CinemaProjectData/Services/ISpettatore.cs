using CinemaProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public interface ISpettatore
    {
        bool Minore(Spettatore s);
        bool Maggiore(Spettatore s);
        void ScontoAnziani(Spettatore s);
        void ScontoBambini(Spettatore s);
    }
}
