using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public interface ISpettatore
    {
        bool Minore();
        bool Maggiore();
        void ScontoAnziani();
        void ScontoBambini();
    }
}
