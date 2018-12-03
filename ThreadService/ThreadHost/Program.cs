using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ThreadHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ThreadService.ThreadService)))
            {
                host.Open();
                Console.WriteLine("Host started");
                Console.ReadLine();
            }
        }
    }
}
