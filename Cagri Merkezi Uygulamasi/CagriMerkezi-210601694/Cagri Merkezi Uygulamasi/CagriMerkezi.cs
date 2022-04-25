using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public class CagriMerkezi
    {
        public List<GirilenNotlar> girilenNot=new List<GirilenNotlar>();
        public List<MusteriTemsilcisi> temsilci = new List<MusteriTemsilcisi>();
        public void NotEkle(GirilenNotlar n)
        {
            girilenNot.Add(n);
        }
        public void TemsilcileriEkle(MusteriTemsilcisi mt)
        {
            temsilci.Add(mt);
        }
    }
}
