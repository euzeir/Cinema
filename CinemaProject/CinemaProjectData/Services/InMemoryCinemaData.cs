using CinemaProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaProjectData.Services
{
    public class InMemoryCinemaData
    {
        private Cinema cinema;
        private List<SalaCinematografica> sale;
        private List<Spettatore> spettatoriSalaUno;
        private List<Spettatore> spettatoriSalaDue;
        private List<Biglietto> biglietti;
        private List<Film> film;

        public InMemoryCinemaData()
        {
            CreateData();
        }

        public Cinema GetCinema()
        {
            return cinema;
        }

        public List<SalaCinematografica> GetSala()
        {
            return sale;
        }

        public List<Spettatore> GetSpettatori()
        {
            return spettatoriSalaUno.Concat(spettatoriSalaDue).ToList();
        }

        public List<Biglietto> GetBiglieti()
        {
            return biglietti;
        }

        public List<Film> GetFilms()
        {
            return film;
        }
        private Cinema CreateData()
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

            cinema = new Cinema() { IdCinema = 1, Sale = sale };

            return cinema;
        }

    }
}
