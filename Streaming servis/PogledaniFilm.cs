﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_servis
{
    public class PogledaniFilm
    {
        public int IdFilma { get; set; }
        public DateTime DatumGledanja { get; set; }

        public PogledaniFilm(int idFilma)
        {
            IdFilma = idFilma;
            DatumGledanja = DateTime.Now;
        }
    }
}
