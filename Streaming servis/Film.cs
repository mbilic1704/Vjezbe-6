using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_servis
{
    public class Film
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        public Film(int id, string naziv)
        {
            Naziv = naziv;
            ID = id;
        }
    }
}
