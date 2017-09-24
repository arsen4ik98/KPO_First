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
            Console.WriteLine(asd.Pop());
            Console.WriteLine(asd.TakeTop());
            Console.ReadKey();
        }
    }
}
