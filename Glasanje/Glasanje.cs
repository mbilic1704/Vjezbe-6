using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiraciLib;

namespace Glasanje
{
    public class Glasanje
    {
        PopisBiraca popis = new PopisBiraca();
        public string Opcija;
        public bool MozeGlasati(string oib)
        { 
            if(popis.PostojiBirac(oib) == true && NijeGlasao(oib) == true)
            {
                return true;
            }
            return false;
        }

        public bool NijeGlasao(string oib)
        {

            if(popis.PostojiBirac(oib) == true && Opcija!="")
            {
               
                return true;
            }

            return false;   
        }

        public void Glasaj(string oib, string opcija)
        {
           
            if(MozeGlasati(oib)==false)
            {
                throw new Exception("Ne mozete glasati.");
               
            }

            if (opcija == "ZA") Form1.za++;
            else if(opcija == "PROTIV") Form1.protiv++;
            if (opcija == "SUZDRZAN") Form1.suzdrzan++;
           
        }
    }
}
