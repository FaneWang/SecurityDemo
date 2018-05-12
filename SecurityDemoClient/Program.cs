using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityDemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                //这里构造函数里面的东西是配置文件中endpoint的name
                ServiceProxy.SecurityServiceClient serviceProxy = new ServiceProxy.SecurityServiceClient("WSHttpBinding_SecurityService");

                string name = "onepig";
                string result = string.Empty;

                result = serviceProxy.SayingHello(name);

                Console.WriteLine("Returned value is {0}...", result);


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:{0}", e.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}
