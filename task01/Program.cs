using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task01.UI;
using task01.DL;
using task01.BL;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Itemmenu.read_menu();
            while (true)
            {  
                Console.Clear();
                
                int option = Main_menu.main_menu();
                Platform(option);
            }
        }
        static void Platform(int option)
        {
            if(option==1)
            {
                string name = "", type = "";
                int price = 0;
                Menu_.menu_print(ref name,ref type,ref price);
                Menu m = new Menu(name,type,price);
                Itemmenu.itemmenu.Add(m);
                Itemmenu.store_menu();
            }
            if(option==2)
            {
               Menu.View_cheapest_item();
            }
            if(option==3)
            {
                Menu_.view(1);
            }
            if(option==4)
            {
                Menu_.view(2);
            }
            if(option==5)
            {
              order_UI.order_();
            }
            if(option==6)
            {
                if(orderlist.orders.Count==0)
                {
                    order_UI.fulfill_order(0);
                }
                else
                    order_UI.fulfill_order(1);

            }
            if(option==7)
            {
               order_UI.View_orders_list();
            }
            if(option==8)
            {
                order_UI.bill();
            }
        }
    }
}
