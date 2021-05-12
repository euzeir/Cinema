using CinemaProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public class CinemaManagement : ICinema, ISalaCinematografica, ISpettatore, IBiglietto, IStatistiche
    {
        public Cinema cinema { get; set; }
        public List<SalaCinematografica> saleCinema { get; set; }
        public List<Spettatore> listaSpet { get; set; }

        public double incassoCinema { get; set; }
        public double incassoSala { get; set; }
        public bool minore { get; set; }
        public bool maggiore { get; set; }
        public bool permettereEntrata { get; set; }
        public double scontoAnziani { get; set; }
        public double scontoBambini { get; set; }

        InMemoryCinemaData m = new InMemoryCinemaData();

        public void ApplicaScontoAnziani(int id)
        {
            ScontoAnziani(id);
        }

        public double CalcolareIncassoSala(int id)
        {
            cinema = m.GetCinema();
            var sala = cinema.Sale.FirstOrDefault(s => s.IdSala == id);
            double total = 0;
            foreach (var spettatore in sala.Spettatori)
            {
                total += spettatore.BigliettoSpettatore.PrezzoBiglietto;
            }
            incassoSala = total;
            return total;
        }

        public void CalcolareRiduzioneBambini(int id)
        {
            ScontoBambini(id);
        }

        public string FilmConMaggiorNumeroDiSpettatori()
        {
            throw new NotImplementedException();
        }

        public string FilmConMinorNumeroDiSpettatori()
        {
            throw new NotImplementedException();
        }

        public decimal GenerePreferito()
        {
            throw new NotImplementedException();
        }

        public double IncassoCinema()
        {
            cinema = m.GetCinema();
            double total = 0;
            foreach (var sala in cinema.Sale)
            {
                foreach (var spettatore in sala.Spettatori)
                {
                    total += spettatore.BigliettoSpettatore.PrezzoBiglietto;
                }
            }
            incassoCinema = total;
            return total;
        }

        public bool Maggiore(int id)
        {
            listaSpet = m.GetSpettatori();
            var spet = listaSpet.FirstOrDefault(sp => sp.IdSpettatore == id);
            var age = (int)Math.Round(((DateTime.Now - spet.DataNascitaSpettatore).TotalDays) / 365);
            bool ret = age >= 18 ? true : false;
            maggiore = ret;
            return ret;
        }

        public bool Minore(int id)
        {
            listaSpet = m.GetSpettatori();
            var spet = listaSpet.FirstOrDefault(sp => sp.IdSpettatore == id);
            var age = (int)Math.Round(((DateTime.Now - spet.DataNascitaSpettatore).TotalDays) / 365);
            bool ret = age < 18 ? true : false;
            minore = ret;
            return ret;
        }

        public void PermettereIngressoSala(int idSala, int id)
        {
            listaSpet = m.GetSpettatori();
            var spet = listaSpet.FirstOrDefault(sp => sp.IdSpettatore == id);
            var age = (int)Math.Round(((DateTime.Now - spet.DataNascitaSpettatore).TotalDays) / 365);

            saleCinema = m.GetSala();
            var sal = saleCinema.FirstOrDefault(s => s.IdSala == idSala);
            var numeroSpettatoriAttuali = sal.Spettatori.Count;
            if (sal.Spettatori.Count < sal.MassimoNumeroDiSpettatori)
            {
                permettereEntrata = true;
                numeroSpettatoriAttuali++;
            }
            else
            {
                permettereEntrata = false;
                throw new Exception("SalaAlCompletto!");
            }

            if (age < 14)
            {
                permettereEntrata = false;
                throw new Exception("FilmVietato");
            }
            else
            {
                permettereEntrata = true;
                numeroSpettatoriAttuali++;
            }
        }

        public void ScontoAnziani(int id)
        {
            listaSpet = m.GetSpettatori();
            var s = listaSpet.FirstOrDefault(sp => sp.IdSpettatore == id);
            var age = (int)Math.Round(((DateTime.Now - s.DataNascitaSpettatore).TotalDays) / 365);

            if (age > 70)
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 0.1;
            }
            else
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 1.0;
            }
            scontoAnziani = s.BigliettoSpettatore.PrezzoBiglietto;
        }

        public void ScontoBambini(int id)
        {
            listaSpet = m.GetSpettatori();
            var s = listaSpet.FirstOrDefault(sp => sp.IdSpettatore == id);
            var age = (int)Math.Round(((DateTime.Now - s.DataNascitaSpettatore).TotalDays) / 365);

            if (age < 5)
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 0.5;
            }
            else
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 1.0;
            }
            scontoBambini = s.BigliettoSpettatore.PrezzoBiglietto;
        }

        public void SvuotareSala(int id)
        {
            m.GetSala().FirstOrDefault(s => s.IdSala == id).Spettatori.Clear();
        }
    }
}
