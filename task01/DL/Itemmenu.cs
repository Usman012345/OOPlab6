using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using task01.BL;

namespace task01.DL
{
    class Itemmenu
    {
        public static List<Menu> itemmenu = new List<Menu>();
        public static void store_menu()
        {
          if( File.Exists("E:\\OOP\\OOPlab6\\task01\\Menu.txt"))
            {
                StreamWriter data = new StreamWriter("E:\\OOP\\OOPlab6\\task01\\Menu.txt", true);
                foreach(Menu data_ in itemmenu)
                {
                    data.WriteLine("{0},{1},{2}", data_.name, data_.type, data_.price);
                }
                data.Flush();
                data.Close();
            }
        }
        public static void read_menu()
        {
            if (File.Exists("E:\\OOP\\OOPlab6\\task01\\Menu.txt"))
            {
                string line;
                string[] line_ = new string[3];
                int count = 0;
                StreamReader data = new StreamReader("E:\\OOP\\OOPlab6\\task01\\Menu.txt", true);
                while (((line = data.ReadLine()) != null))
                {

                    line_ = line.Split(',');
                   
                    string name = line_[0];
                    string type = line_[1];
                    int price = int.Parse(line_[2]);
                    itemmenu.Add(new Menu(name, type, price));
                    count++;
                }
                data.Close();
            }
        }
    }
}
