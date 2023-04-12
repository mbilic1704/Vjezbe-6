using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_servis
{
    public class KatalogFilmova
    {
        public  List<Film> ListaSvihFilmova { get; set; } = new List<Film>();
        public  List<PogledaniFilm> ListaPogledanihFilmova { get; set; } = new List<PogledaniFilm>();
        public KatalogFilmova()
        {
           

            ListaSvihFilmova.Add(new Film(1, "Batman"));
            ListaSvihFilmova.Add(new Film(2, "Superman"));
            ListaSvihFilmova.Add(new Film(3, "Spiderman"));
            ListaSvihFilmova.Add(new Film(4, "Ironman"));
            ListaSvihFilmova.Add(new Film(5, "Hulk"));
        }

        public List<Film> DohvatiSveFilmove()
        {
            return ListaSvihFilmova;
        }

        public List<PogledaniFilm> DohvatiPogledaneFilmove()
        {
         
            return ListaPogledanihFilmova;
        }

        public void DodajPogledaniFilm(Film noviPogledaniFilm)
        {
            foreach(Film f in ListaSvihFilmova)
            {
                if(noviPogledaniFilm.ID == f.ID)
                {
                    ListaPogledanihFilmova.Add(new PogledaniFilm(noviPogledaniFilm.ID));
                    
                }
            }
        }
    }
}
