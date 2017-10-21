using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KPO_FirstLab
{
    public class QueueRealisation<T> : IQueueRealisation<T>, IEnumerable<T>, ICloneable
    {

        public T[] Que = new T[10];
        public int count = 0;

        public T Pop()
        {
            if (Que.Length == 0 || IsEmpty()) //fixed with method (there was count checker), а если по-русски, то я немного не то использовал. 
            //создал метод проверки на пустоту и не использовал его, лол. чудовище
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

        public bool IsEmpty()
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

        public T TakeTop()
        {
            return Que[0];
        }



        //public object Clone() //поверхностное (неглубокое) копирование
        //{
        //    return this.MemberwiseClone();
        //}


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; ++i)

                yield return Que[i]; // 2
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public object Clone() //поверхностное (неглубокое) копирование
        {
            return this.MemberwiseClone();
        }
    }
}
