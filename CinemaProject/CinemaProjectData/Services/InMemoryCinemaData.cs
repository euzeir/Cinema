using CinemaProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public class InMemoryCinemaData : ICinema, ISalaCinematografica, ISpettatore, IBiglietto, IStatistiche
    {
        List<SalaCinematografica> sale;
        List<Spettatore> spettatoriSalaUno;
        List<Spettatore> spettatoriSalaDue;
        List<Biglietto> biglietti;
        List<Film> film;

        public InMemoryCinemaData()
        {
            //film
            film = new List<Film>()
            {
                new Film
                {
                    IdFilm = 1,
                    TitoloFilm = "Il Signore degli Anelli",
                    AutoreFilm = "J. R. R. Tolkien",
                    ProduttoreFilm = "Peter Jackson",
                    GenereFilm = "Fantasy",
                    DurataFilm = 178
                },

                new Film
                {
                    IdFilm = 2,
                    TitoloFilm = "Guerre Stellari",
                    AutoreFilm = "George Lucas",
                    ProduttoreFilm = "Gary Kurtz",
                    GenereFilm = "Fantascienza",
                    DurataFilm = 121
                },
            };
            //biglietti
            biglietti = new List<Biglietto>()
            {
                new Biglietto 
                { 
                    IdBiglietto = 1, 
                    Posizione = 23, 
                    PrezzoBiglietto = Convert.ToDouble(24.6)
                },

                new Biglietto 
                {
                    IdBiglietto = 2,
                    Posizione = 99,
                    PrezzoBiglietto = Convert.ToDouble(20.5)
                },

                new Biglietto 
                {
                    IdBiglietto = 3,
                    Posizione = 45,
                    PrezzoBiglietto = Convert.ToDouble(23.5)
                },

                new Biglietto {
                    IdBiglietto = 4,
                    Posizione = 32,
                    PrezzoBiglietto = Convert.ToDouble(21.8)
                },
            };

            //spettatori
            spettatoriSalaUno = new List<Spettatore>()
            {
                new Spettatore { 
                    IdSpettatore = 1,
                    NomeSpettatore = "Mario",
                    CognomeSpettatore = "Rossi",
                    DataNascitaSpettatore = Convert.ToDateTime("11/10/1992"),
                    BigliettoSpettatore = biglietti[0]
                },

                new Spettatore
                {
                    IdSpettatore = 2,
                    NomeSpettatore = "Andrea",
                    CognomeSpettatore = "Verdi",
                    DataNascitaSpettatore = Convert.ToDateTime("21/03/1956"),
                    BigliettoSpettatore = biglietti[1]
                }
            };

            spettatoriSalaDue = new List<Spettatore>()
            {
                new Spettatore
                {
                    IdSpettatore = 3,
                    NomeSpettatore = "Alessio",
                    CognomeSpettatore = "Monti",
                    DataNascitaSpettatore = Convert.ToDateTime("15/03/1940"),
                    BigliettoSpettatore = biglietti[2]
                },

                new Spettatore
                {
                    IdSpettatore = 4,
                    NomeSpettatore = "Maurizio",
                    CognomeSpettatore = "Bruni",
                    DataNascitaSpettatore = Convert.ToDateTime("25/08/1970"),
                    BigliettoSpettatore = biglietti[3]
                }
            };

            //sale
            sale = new List<SalaCinematografica>()
            {
                new SalaCinematografica
                {
                    IdSala = 1,
                    MassimoNumeroDiSpettatori = 100,
                    Spettatori = spettatoriSalaUno,
                    FilmInProiezione = film[0]
                },

                new SalaCinematografica
                {
                    IdSala = 2,
                    MassimoNumeroDiSpettatori = 150,
                    Spettatori = spettatoriSalaDue,
                    FilmInProiezione = film[1]
                },
            };
        }

        public void ApplicaScontoAnziani(Spettatore s)
        {
            ScontoAnziani(s);
        }

        public double CalcolareIncassoSala(SalaCinematografica s)
        {
            double total = 0;
            foreach (var spettatore in s.Spettatori)
            {
                total += spettatore.BigliettoSpettatore.PrezzoBiglietto;
            }
            return total;
        }

        public void CalcolareRiduzioneBambini(Spettatore s)
        {
            ScontoBambini(s);
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

        public double IncassoCinema(List<SalaCinematografica> s)
        {
            double total = 0.0;
            foreach (var sala in s)
            {
                foreach (var spettatore in sala.Spettatori)
                {
                    total += spettatore.BigliettoSpettatore.PrezzoBiglietto;
                }
            }

            return total;
        }

        public bool Maggiore(Spettatore s)
        {
            var age = (int)Math.Round(((DateTime.Now - s.DataNascitaSpettatore).TotalDays) / 365);
            return age >= 18 ? true : false;
        }

        public bool Minore(Spettatore s)
        {
            var age = (int)Math.Round(((DateTime.Now - s.DataNascitaSpettatore).TotalDays) / 365);
            return age < 18 ? true : false;
        }

        public void PermettereIngressoSala(SalaCinematografica s, Spettatore sp)
        {
            var age = (int)Math.Round(((DateTime.Now - sp.DataNascitaSpettatore).TotalDays) / 365);

            var numeroSpettatoriAttuali = s.Spettatori.Count;
            if (s.Spettatori.Count < s.MassimoNumeroDiSpettatori)
            {
                numeroSpettatoriAttuali++;
            }
            else
            {
                throw new Exception("SalaAlCompletto!");
            }

            if (age < 14)
            {
                throw new Exception("FilmVietato");
            }
        }

        public void ScontoAnziani(Spettatore s)
        {
            var age = (int)Math.Round(((DateTime.Now - s.DataNascitaSpettatore).TotalDays) / 365);

            if (age > 70)
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 0.1;
            }
            else
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 1.0;
            }
        }

        public void ScontoBambini(Spettatore s)
        {
            var age = (int)Math.Round(((DateTime.Now - s.DataNascitaSpettatore).TotalDays) / 365);

            if (age < 5)
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 0.5;
            }
            else
            {
                s.BigliettoSpettatore.PrezzoBiglietto *= 1.0;
            }
        }

        public void SvuotareSala(int id)
        {
            sale.FirstOrDefault(s => s.IdSala == id).Spettatori.Clear();
        }
    }
}
