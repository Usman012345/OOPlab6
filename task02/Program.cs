using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task02.UI;
using task02.BL;
using task02.DL;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            while (true)
            {
                Console.Clear();
                menu.menu_(ref option);
                if (option == 1)
                    Gameobject.set_point(1);
                if (option == 2)
                {
                    int op = 0;
                    premises.premisis(ref op);
                    if (op == 2)
                        Gameobject.set_point(2);
                    if (op == 1)
                    {
                        Boundry_ b = new Boundry_();
                        Gameobject.bottomleft = b.Bottomleft;
                        Gameobject.bottomright = b.Bottomright;
                        Gameobject.topleft = b.Topleft;
                        Gameobject.topright = b.Topright;
                    }
                }
                if (option == 3)
                {
                    int option_ = 0;
                    Gameobject.direction_(ref option_);
                }
                if (option == 4)
                    Gameobject.shape();
                if (option == 5)
                {
                    Console.Clear();
                    motion m = new motion();
                }
                if (option == 6)
                {
                    Console.Clear();
                }
                if (option == 7)
                {
                    Console.Clear();
                    int t = Gameobject.start.X;
                    foreach (char data in Gameobject.obj)
                    {
                        Console.SetCursorPosition(t,3);
                        Console.Write(data);
                        t++;
                        
                    }
                    Console.ReadKey();
                }
                if(option==8)
                {
                    Storedata.readdata();
                }
                if(option==0)
                {
                    Storedata.storedata();
                    Environment.Exit(0);
                }
            }
        }
    }
}
