# Cinema

PROGETTO CINEMA

Sviluppare un'applicazione Web che consenta di gestire una sala cinematografica.

L’applicazione prevede lo sviluppo delle seguenti entità principali:

Cinema
Sala Cinematografica
Spettatore
Film
Biglietto
Cinema

L'entità Cinema avrà come attributi un insieme di oggetti di tipo sala cinematografica e consentirà di calcolare l’incasso del cinema sommando gli incassi delle sale cinematografiche.

Sala Cinematografica

La Sala (o SalaCinematografica) è in grado di contenere un numero definito di spettatori, pertanto ha come attributi un insieme di spettatori di dimensione fissata e contiene il riferimento al film che si sta proiettando al suo interno.

Devono essere inoltre definiti funzionalità per svuotare la sala, e per consentire l’ingresso ad uno spettatore se e solo se ci sono ancora posti disponibili altrimenti deve essere lanciata l’eccezione “SalaAlCompleto”; se inoltre lo spettatore è minore di 14 anni, e sta tentando di accedere ad una sala in cui si proietta un film di genere horror, deve essergli impedito l’accesso e lanciata l’eccezione “FilmVietato”.

Deve essere inoltre possibile calcolare l’incasso della singola sala.

Film

L'entità Film conterrà attributi quali titolo del film, autore, produttore, genere e durata.

Spettatore

L'entità Spettatore contiene invece attributi come

idSpettatore
nome
cognome
data nascita
biglietto
oltre ad un funzionalità che restituisce un valore booleano per determinare la minore o maggiore età dello spettatore. Inoltre se lo spettatore ha un età maggiore dei 70 anni deve essere praticato uno sconto del 10% sul prezzo del biglietto e se ha un età inferiore ai 5 anni deve essere praticato uno sconto del 50% sul prezzo intero del biglietto;

Biglietto

L'entità Biglietto contiene gli attributi posizione che indica il posto a sedere nella sala cinematografica ed il prezzo. L'entità biglietto conterrà le seguenti funzionalità

Applicare riduzioni agli anziani
Calcolare la riduzione per Bambini
per determinare la riduzione sul prezzo intero del biglietto.

Statistiche

In forma del tutto opzionale, da sviluppare se e soltanto se la web app sviluppata copre interamente in punti precedenti, l’applicazione deve essere in grado di generare statistiche riguardanti

le percentuali di spettatori che seguono un determinato genere
il film che ha avuto maggior numero di spettatori
il film che ha avuto un minor numero di spettatori
L'utilizzo di librerie/framework che agevolino/migliorino la gestione dell'aspetto grafico saranno valutate positivamente
