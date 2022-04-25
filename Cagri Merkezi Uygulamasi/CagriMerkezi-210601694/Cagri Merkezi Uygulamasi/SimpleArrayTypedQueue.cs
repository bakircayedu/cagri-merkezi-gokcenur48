using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public class SimpleArrayTypedQueue : IQueue

    {
        private MusteriTemsilcisi[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public SimpleArrayTypedQueue(int size)
        {
            this.size = size; 
            Queue = new MusteriTemsilcisi[size];
        }
        public void Insert(MusteriTemsilcisi mt)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Queue dolu.");
            if (front == -1)
                front = 0;
            Queue[++rear] = mt;
            count++;
        }
        public MusteriTemsilcisi Remove()
        {

            if (IsEmpty())

            throw new Exception("Queue boş.");
            MusteriTemsilcisi temp = Queue[front];
            Queue[front] = null;
            front++;
            count--;
            return temp;
        }

        public MusteriTemsilcisi Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue Boş.");
            }
            else
            {
                MusteriTemsilcisi temp = Queue[front];
                return temp;
            }
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }

    }
}

