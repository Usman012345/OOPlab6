using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02.UI
{
    class premises
    {
        public static void premisis(ref int op)
        {
            Console.WriteLine("1.default premises: ");
            Console.WriteLine("2.Enter premises: ");
            op = int.Parse(Console.ReadLine());
        }
    }
}
