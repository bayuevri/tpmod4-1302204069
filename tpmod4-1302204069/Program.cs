using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302204069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data_Generic<String> data = new Data_Generic<string>("1302204069");
            data.printInfo();
            HaloGeneric<String> halo = new HaloGeneric<string>();
            halo.SapaUser("bayu");
        }
    }
}
