using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task01.UI;
using task01.DL;

namespace task01.BL
{
    class Menu
    {
       public string name = "", type = "";
       public int price = 0;
        public Menu(string name,string type,int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public static void View_cheapest_item()
        {
           Itemmenu.itemmenu= Itemmenu.itemmenu.OrderBy(x => x.price).ToList();
           Menu_.view(3);
        }
    }
}
