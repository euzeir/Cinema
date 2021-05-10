using CinemaProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public interface ICinema
    {
        IEnumerable<SalaCinematografica> IncassoCinema();
    }
}
