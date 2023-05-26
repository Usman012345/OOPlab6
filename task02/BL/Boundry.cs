using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02.BL
{
    class Boundry_
    {
      public point Topleft;
       public point Topright;
       public point Bottomright;
       public point Bottomleft;
        public Boundry_()
        {
            this.Bottomleft =new point(0,90);
            this.Bottomright = new point(90, 90);
            this.Topleft = new point(0, 0);
            this.Topright = new point(90, 0);
        }
        public Boundry_(point Topleft,point Topright,point Bottomleft,point Bottomright)
        {
            this.Bottomright = Bottomright;
            this.Bottomleft = Bottomleft;
            this.Topright = Topright;
            this.Topleft = Topleft;
        }
    }
}
