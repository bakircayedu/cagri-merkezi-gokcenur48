using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public class LinkedList:LinkedListADT
    {
        public override void InsertFirst(Cagri value)
        {
            Node gecici = new Node()
            {
                Data = value,
            };
            if (Head == null)
            {
                Head = gecici;
            }
            else
            {
                gecici.Next = Head;
                Head = gecici;
            }
        }
        public override void InsertLast(Cagri value)
        {
            Node old = Head;
            Node new1 = new Node()
            {
                Data = value,
            };
            if (Head == null)
            {
                Head = new1;
            }
            else
            {
                while (old != null)
                {
                    if (old.Next != null)
                    {
                        old = old.Next;
                    }
                    else
                    {
                        old.Next = new1;
                        new1.Next = null;
                        break;
                    }
                }
            }
        }
        public override void DeleteFirst()
        {
            throw new NotImplementedException();
        }
        public override void DeleteLast()
        {
            Node old = Head;

            while (old != null)
            {
                if (old.Next.Next != null)
                {
                    old = old.Next;
                }
                else
                {
                    old.Next = null;
                   
                }
            }
        }
        public override void DeletePos(Cagri delete)
        {
            throw new NotImplementedException();
        }
    }
}
