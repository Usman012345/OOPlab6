using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task02.UI;

namespace task02.BL
{
    class point
    {
        public int X;
        public int Y;
        public point()
        {
            this.X = 0;
            this.Y = 0;
        }
        public point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static void SetXY(ref int x,ref int y)
        {
            setxy.Set_xy(ref x,ref y);
        }
    }
}
