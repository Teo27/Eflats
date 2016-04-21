using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ServiceModel;
using ServerController;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread update = new Thread(new ThreadStart(CtrUpdate.Update));
            Thread host = new Thread(new ThreadStart(RunHost));

            host.Start();
            update.Start();  


        }


        public static void RunHost()
        {
            using (ServiceHost host = new ServiceHost(typeof(WcfEFlatsService.WcfEFlatsService)))
            {
                host.Open();
                Console.WriteLine("Host has started @ time: " + DateTime.Now.ToString());

                while (true)
                {
                    Console.ReadLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
