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
        List<Spettatore> spettatori;
        List<Biglietto> biglietti;

        public InMemoryCinemaData()
        {
            //biglietti
            biglietti = new List<Biglietto>()
            {
                new Biglietto { 
                    IdBiglietto = 1, 
                    Posizione = 23, 
                    PrezzoBiglietto = Convert.ToDecimal(24.6)
                },

                new Biglietto {
                    IdBiglietto = 2,
                    Posizione = 99,
                    PrezzoBiglietto = Convert.ToDecimal(20.5)
                },

                new Biglietto {
                    IdBiglietto = 3,
                    Posizione = 45,
                    PrezzoBiglietto = Convert.ToDecimal(23.5)
                },

                new Biglietto {
                    IdBiglietto = 4,
                    Posizione = 32,
                    PrezzoBiglietto = Convert.ToDecimal(21.8)
                },
            };

            //spettatori
            spettatori = new List<Spettatore>()
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
                },

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
                    Spettatori = spettatori.GetRange(0, 2),
                    FilmInProiezione = "Il Signore degli Anelli"
                },

                new SalaCinematografica
                {
                    IdSala = 2,
                    MassimoNumeroDiSpettatori = 150,
                    Spettatori = spettatori.GetRange(2, 2),
                    FilmInProiezione = "Guerre Stellari"
                },
            };
        }

        public void ApplicaScontoAnziani()
        {
            throw new NotImplementedException();
        }

        public decimal CalcolareIncassoSala()
        {
            throw new NotImplementedException();
        }

        public void CalcolareRiduzioneBambini()
        {
            throw new NotImplementedException();
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

        public IEnumerable<SalaCinematografica> IncassoCinema()
        {
            throw new NotImplementedException();
        }

        public bool Maggiore()
        {
            throw new NotImplementedException();
        }

        public bool Minore()
        {
            throw new NotImplementedException();
        }

        public void PermettereIngressoSala()
        {
            throw new NotImplementedException();
        }

        public void ScontoAnziani()
        {
            throw new NotImplementedException();
        }

        public void ScontoBambini()
        {
            throw new NotImplementedException();
        }

        public void SvuotareSala()
        {
            throw new NotImplementedException();
        }
    }
}
