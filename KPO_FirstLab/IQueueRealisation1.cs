using System;
namespace KPO_FirstLab
{
    interface IQueueRealisation1<T>
    {
        System.Collections.Generic.IEnumerator<T> GetEnumerator();
    }
}
