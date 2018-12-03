using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleThreadHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadService.ThreadServiceClient client = new ThreadService.ThreadServiceClient();
            for(int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(client.DoWork);
                thread.Start();
            }
            Console.ReadLine();
        }
    }
}
