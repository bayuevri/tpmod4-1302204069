using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302204069
{
    internal class Data_Generic<T>
    {
        private T data;

        public Data_Generic(T data)
        {
            this.data = data; 
        }

        public void printInfo()
        {
            Console.WriteLine("data yang disimpan adalah:" + this.data);
        }

    }
}
