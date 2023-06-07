using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new TcpChannel(8099);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteDataLayer), "Service", WellKnownObjectMode.Singleton);
            Console.WriteLine("Press any key to stop the TCP server");
            Console.ReadLine();
        }
    }
}
