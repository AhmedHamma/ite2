using lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace projetIteration2bis
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
            SecurityProtocolType.Tls;

            Class1 lib = new Class1();
            lib.getFromLocation((root) =>
            {
                foreach (Root r in root)
                {
                    Console.WriteLine(r.name);
                }

            });

            /*new API().getFromLocation((root) =>
            {
                foreach (Root r in root)
                {
                    Console.WriteLine(r.name);
                }

            });*/

            Console.ReadLine();

        }
    }
}
