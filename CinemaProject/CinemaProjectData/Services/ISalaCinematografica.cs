using CinemaProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public interface ISalaCinematografica
    {
        void SvuotareSala(int idSala);
        void PermettereIngressoSala(SalaCinematografica s, Spettatore sp);
        double CalcolareIncassoSala(SalaCinematografica s);
    }
}
