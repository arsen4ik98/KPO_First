using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KPO_FirstLab;

namespace QueueRealisation_Test
{
    [TestFixture]
    public class Class1
    {
        [Test()]
        public void asd()
        {
            QueueRealisation<int> asd = new QueueRealisation<int>();
            asd.Push(1);
            asd.Push(2);
            asd.Push(3);
            int expec = 2;
            asd.Pop();
            int act = asd.Pop();
            Assert.AreEqual(expec, act);
        }
    }
}
