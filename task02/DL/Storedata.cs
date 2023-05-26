using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using task02.BL;

namespace task02.DL
{
    class Storedata
    {
        public static void storedata()
        {
            StreamWriter data = new StreamWriter("E:\\OOP\\OOPlab6\\task02\\data.txt", true);
            data.Write(Gameobject.start.X+","+Gameobject.start.Y+",");
            data.Write(Gameobject.direction);
            data.Flush();
            data.Close();
        }
        public static void readdata()
        {
            StreamReader data = new StreamReader("E:\\OOP\\OOPlab6\\task02\\data.txt", true);
            string line = data.ReadLine();
            string[] line_ = line.Split(',');
            Gameobject.start.X = int.Parse(line_[0]);
            Gameobject.start.Y = int.Parse(line_[1]);
            Gameobject.direction = line_[2];
            data.Close();
            Boundry_ b = new Boundry_();
            Gameobject.bottomleft = b.Bottomleft;
            Gameobject.bottomright = b.Bottomright;
            Gameobject.topleft = b.Topleft;
            Gameobject.topright = b.Topright;
        }
    }
}
