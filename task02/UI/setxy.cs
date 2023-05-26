using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02.UI
{
    class setxy
    {
        public static void Set_xy(ref int x,ref int y)
        {
            Console.WriteLine("Enter X:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            y = int.Parse(Console.ReadLine());
        }
    }
}
