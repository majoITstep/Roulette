using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class RuletovyStol
    {
        public HraciePole[] HraciePolia = new HraciePole[37];
        public RuletovyStol()
        {
            Farba[] rozmiestnenieFarieb = new Farba[37] { Farba.zelena, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena };
            for (int i = 0; i < rozmiestnenieFarieb.Length; i++)
            {
                HraciePolia[i].Farba = rozmiestnenieFarieb[i];
                HraciePolia[i].Cislo = 1;
                HraciePolia[i].Rada = vratRadu(i);
                HraciePolia[i].Parnost = vratParnost(i);           
                        
            }

        }
        private Parnost vratParnost(int cislo)
        {
            if (cislo == 0) return Parnost.ziadna;
            if (cislo % 2 == 0) return Parnost.parna;
            return Parnost.neparna;
        }

        private Rada vratRadu(int cislo)
        {
            if (cislo == 0) return Rada.ziadna;
            if (cislo == 1 || cislo - 1 % 3 == 0) return Rada.prva;
            if(cislo == 2 || cislo - 2 % 3 == 0) return Rada.druha;
            return Rada.tretia;
        }
    }
}
