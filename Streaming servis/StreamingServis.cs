using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_servis
{
   
    public class StreamingServis
    {
        KatalogFilmova katalog = new KatalogFilmova();

        public List<Film> NeodgledaniFilmovi = new List<Film>();
        public List<Film> DohvatiNepogledaneFilmove()
        {
            List<Film> svi = katalog.DohvatiSveFilmove();
            List<PogledaniFilm> pogledani = katalog.DohvatiPogledaneFilmove();
            NeodgledaniFilmovi.Clear();

            if (pogledani.Count == 0) return svi;

            foreach(Film f in svi)
            {
                foreach(PogledaniFilm p in pogledani)
                {
                    if(f.ID != p.IdFilma)
                    {
                        NeodgledaniFilmovi.Add(f);
                        
                    }
                }
            }

            return NeodgledaniFilmovi;

        }

        public void PogledajFilm(Film odabraniFilm)
        {
            katalog.DodajPogledaniFilm(odabraniFilm);
        }
    }
}
