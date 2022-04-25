using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public interface IQueue
    {
        void Insert(MusteriTemsilcisi mt);
        MusteriTemsilcisi Remove();
        MusteriTemsilcisi Peek();
        Boolean IsEmpty();
    }
}
