using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityDemo
{
   public class SecurityServiceImpl : SecurityService
    {
        public string SayingHello(string name)
        {
            Console.WriteLine("Hello,{0},Calling at {1}", name, DateTime.Now.ToLongTimeString());
            return "Hello," + name;
        }
    }
}
