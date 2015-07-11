using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods; //using methods from my extension methods class
namespace spojApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumthing");
          // PRIME_T run_PRIME_T = new PRIME_T();
          // run_PRIME_T.run();
          // FCTRL3 run_FCTRL3 = new FCTRL3();
          // run_FCTRL3.run();
          //PA05_POT run_PA05_POT = new PA05_POT();
          //run_PA05_POT.run();
          // FLAMASTE run_FLAMASTE = new FLAMASTE();
          //  run_FLAMASTE.run();
            int i = 5;
            Console.WriteLine(i.pow()+" "+i.pow(3));
            Console.ReadKey();
        }
    }
}
