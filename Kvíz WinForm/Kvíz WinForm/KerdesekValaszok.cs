using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvíz_WinForm
{
    class KerdesekValaszok
    {
        public int Sorszam;
        public string Kerdes;
        public string ALehetoseg;
        public string BLehetoseg;
        public string CLehetoseg;
        public string DLehetoseg;
        public string Valasz;

        public KerdesekValaszok(string sor)
        {
            var dbok = sor.Split(';');
            this.Sorszam = int.Parse(dbok[0]);
            this.Kerdes = dbok[1];
            this.ALehetoseg = dbok[2];
            this.BLehetoseg = dbok[3];
            this.CLehetoseg = dbok[4];
            this.DLehetoseg = dbok[5];
            this.Valasz = dbok[6];
        }
    }
}
