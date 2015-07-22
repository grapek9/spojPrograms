using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class NWD
    {
        public void run()
        {
            Console.WriteLine("Type number of tests");
            String input;
            input = Console.ReadLine();
            int range;
            try
            {
                range = Int32.Parse(input);
                String[] digits = new String[range];
                for (int i = 0; i < range; i++)
                {
                    input = Console.ReadLine();
                    digits[i] = input;
                }

                foreach (String iterator in digits)
                {
                }

            }
        }
    }
}
