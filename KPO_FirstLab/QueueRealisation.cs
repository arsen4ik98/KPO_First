using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_FirstLab
{
    class QueueRealisation<T> : IQueueRealisation<T>
    {

        private T[] Que = new T[10];
        private int count = 0;

        public T Pop()
        {
            if (Que.Length == 0)
            {
                throw new Exception("massive is empty");
            }
            else
            {
                T savedElement = Que[0];
                for (int i = 0; i < Que.Length - 1; i++)
                {
                    Que[i] = Que[i + 1];
                }
                count--;
                return savedElement;
            }

        }

        public void Push(T take)
        {
            if (Que.Length == count)
            {
                Array.Resize(ref Que, Que.Length * 2);
                Que[count] = take;
                count++;
            }
            else
            {
                Que[count] = take;
                count++;
            }
        }

        bool IQueueRealisation<T>.IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        T IQueueRealisation<T>.TakeTop()
        {
            return Que[0];
        }
    }
}
