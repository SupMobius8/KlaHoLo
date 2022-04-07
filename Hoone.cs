using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public int Korrus { get; set; }
        public int MajaNum { get; set; }


        public Uks uks;
        public KorteriteMaja korter;


        public Hoone_materjal Hoone_Materjal{get;}

        public Hoone(int pindala = 200, int korrus = 5, int majanum = 12)
        {
            Pindala = pindala;
            Korrus = korrus;
            MajaNum = majanum;
        }

        public Hoone(int pindala, Hoone_materjal hoone_Material)
        {
            Pindala = pindala;
            Hoone_Materjal = Hoone_materjal.Kivimaja;
        }

        public abstract void NaitaInfo();
        public Uks GetUks()
        {
            return uks;
        }
        public KorteriteMaja GetKorter()
        {
            return korter;
        }
    }
}
