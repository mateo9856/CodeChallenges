using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class JobScheduler<T>
    {
        public delegate T ObjDelegate();
        public void Schedule(int n, ObjDelegate f)
        {
            Task.Delay(n);

            f.Invoke();
        }
    }
}
