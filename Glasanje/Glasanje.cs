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
            int za = 0;
            int protiv = 0;
            int suzdrzan = 0;

            if(MozeGlasati(oib)==true)
            {
                if(opcija == "ZA")
                {
                    za++;
                }
                else if(opcija == "PROTIV")
                {
                    protiv++;
                }
                if(opcija == "SUZDRZAN")
                {
                    suzdrzan++;
                }
            }

            Console.WriteLine($"REZULTATI: \n ZA: {za} \n PROTIV:{protiv} \n SUZDRZAN: {suzdrzan}" );
        }
    }
}
