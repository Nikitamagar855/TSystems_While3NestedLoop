using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_While3NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j, k;
            while (i<=3)
            {
                j = 1;
                while (j<=3)
                {
                    k = 1;
                    while (k<=3)
                    {
                        Console.WriteLine(i+"  "+j+" "+k);
                        k++;
                    }
                    j++;
                }
                i++;

            }
            Console.ReadLine();
        }
    }
}
