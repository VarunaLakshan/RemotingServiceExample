using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static IHelloRemotingService.IHelloRemtingService client;
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingService.IHelloRemtingService)Activator.GetObject(
              typeof(IHelloRemotingService.IHelloRemtingService),
              "tcp://localhost:8080/GetMessage");
           Console.WriteLine(client.GetMessage("varuna"));
            Console.ReadLine();
        }
    }
}
