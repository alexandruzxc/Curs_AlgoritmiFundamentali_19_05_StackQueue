using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_AlgoritmiFundamentali_19_05_StackQueue
{
    public class triData
    {
        int l, c, v;

        public triData(int l, int c, int v)
        {
            this.l = l;
            this.c = c;
            this.v = v;
        }  
        public void view()
        {
            Console.Write("(" + l + "," + c + "," + v + ")");
        }
            

    }
}
