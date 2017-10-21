using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            Console.WriteLine(asd.IsEmpty());
            asd.Push(1);
            asd.Push(2);
            asd.Push(4);
            Console.WriteLine("Убираем " + asd.Pop());
            Console.WriteLine("Самая верхняя " + asd.TakeTop());

            Console.WriteLine("Очередь");
            foreach (var i in asd)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Клон");

            QueueRealisation<int> stack2 = (QueueRealisation<int>)asd.Clone();
            
            foreach (var i in stack2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
