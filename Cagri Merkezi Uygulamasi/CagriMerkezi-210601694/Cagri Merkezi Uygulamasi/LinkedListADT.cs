using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public abstract class LinkedListADT
    {
        
            public Node Head;
            public int Size = 0;
            public abstract void InsertFirst(Cagri value);
            public abstract void InsertLast(Cagri value);
            public abstract void DeleteFirst();
            public abstract void DeleteLast();
            public abstract void DeletePos(Cagri delete);
            
        

    }
}
