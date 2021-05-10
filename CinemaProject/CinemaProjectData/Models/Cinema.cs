using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Models
{
    public class Cinema
    {
        public int IdCinema { get; set; }
        public List<SalaCinematografica> Sale { get; set; }
    }
}
