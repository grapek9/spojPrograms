﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class ExtMethods
    {
        public static int pow(this int arg) { return arg * arg; }
        public static int pow(this int arg, int power) { return (int)Math.Pow(arg, power); }
    }
}
