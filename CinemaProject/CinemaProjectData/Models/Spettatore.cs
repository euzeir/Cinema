using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Models
{
    public class Spettatore
    {
        public int IdSpettatore { get; set; }
        public string NomeSpettatore { get; set; }
        public string CognomeSpettatore { get; set; }
        public DateTime DataNascitaSpettatore { get; set; }
        public Biglietto BigliettoSpettatore { get; set; }
    }
}
