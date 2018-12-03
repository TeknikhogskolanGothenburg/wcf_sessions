using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading;

namespace ThreadService
{
   [ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall)]
    public class ThreadService : IThreadService
    {
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread {0} processing request at {1}",
                Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
        }
    }
}
