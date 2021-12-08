using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFHostHelloU
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(HelloNameWCFServiceU.HelloNameServiceU)))
            {
                host.Open();
                Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}

