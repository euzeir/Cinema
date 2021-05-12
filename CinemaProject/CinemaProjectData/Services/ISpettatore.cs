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
        bool Minore(int s);
        bool Maggiore(int s);
        void ScontoAnziani(int idSpettatore);
        void ScontoBambini(int idSpettatore);
    }
}
