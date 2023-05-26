using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task02.DL;
using task02.UI;

namespace task02.BL
{
    class Gameobject
    {
        public static char[,] obj = new char[3, 1] { { 'O' }, { 'O' }, { 'O' } };
      public static point start;
        Boundry_ B = new Boundry_();
        public static point bottomleft, bottomright, topleft, topright;
        public static Boundry_ premises=new Boundry_(topleft,topright,bottomleft,bottomright);
        public static string direction;
      /*  public static void Shape()
        { 
            obj = new char[3, 1] { { 'O' }, { 'O' },{ 'O' } };
            foreach (char data in obj)
            {
                Console.WriteLine(data);
            }
        }*/
        public static void shape()
        {
            char x='O', y='O', z='O';
            gameobj.Shape(ref x, ref y, ref z);
            obj = new char[3, 1] { { x }, { y }, { z } };
            /*int t= start.X;
            foreach (char data in obj)
            {
              Console.SetCursorPosition(t, start.Y);
                Console.Write(data);
                t++;
            }*/
        }
        public static void set_point(int option)
        {
            int x = 0, y = 0;
            for (int z = 0; z < 4; z++)
            {
                point.SetXY(ref x, ref y);
                if (option == 1)
                {
                    start = new point(x, y);
                    break;
                }
                else
                {
                    if (z == 0)
                    {
                        writeline.write("bottomleft");
                        bottomleft = new point(x, y);
                    }
                    if (z == 1)
                    {
                        writeline.write("bottomright");
                        bottomright = new point(x, y);
                    }
                    if (z == 2)
                        writeline.write("topleft");
                    topleft = new point(x, y);
                    if (z == 3)
                        writeline.write("topright");
                    topright = new point(x, y);
                }
            }
        }
        public static void direction_(ref int option)
        {
           gameobj.get_direction(ref option);
            if(option==1)
                direction = "LefttoRight";
            if (option == 2)
                direction = "RighttoLeft";
            if (option == 3)
                direction = "Patrol";
            if (option == 4)
                direction = "Diagonal";
            if (option == 5)
                direction = "Projectile";
        }

    }
}
