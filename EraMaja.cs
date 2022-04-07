using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine
{
    public class EraMaja : Hoone
    {
        int pindala;
        string status;
        public int Suurus
        {
            set {
                pindala = value;
                if (pindala < 50) status = "vaike maja";
                else if (pindala >= 50 && pindala < 100) status = "keskmine maja";
                else if (pindala >= 100 && pindala < 150) status = "suur maja";
                else if (pindala >= 150 && pindala < 200) status = "liiga suur maja";
            }
            get { return pindala; }
        }
        public string Info
        {
            get { return status; }
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
            Console.WriteLine($"Mina olen maja, mul on {Korrus} korrused");
            Console.WriteLine($"Mina olen maja, minu number on {MajaNum}");
            Console.WriteLine(Info);
        }
        public EraMaja(int pindala = 50, int korrus = 3, int majanum = 15) : base(pindala, korrus, majanum)
        {
        }
    }
}
