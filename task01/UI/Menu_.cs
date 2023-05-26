using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task01.DL;
using task01.BL;

namespace task01.UI
{
    class Menu_
    {
       public static void menu_print(ref string name, ref string type, ref int price)
        {
            Console.WriteLine("Enter the item name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the item type: ");
            type = Console.ReadLine();
            Console.WriteLine("Enter the price: ");
            price = int.Parse(Console.ReadLine());

        }
        public static void view(int option)
        {
            if(option==1)
            {
               
                foreach(Menu data in Itemmenu.itemmenu)
                {
                    if(data.type=="Drink")
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", data.name, data.type, data.price);
                        
                    }

                }
            }
            if(option==2)
            {
                foreach (Menu data in Itemmenu.itemmenu)
                {

                    if (data.type == "Food")
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", data.name, data.type, data.price);
                       
                    }

                }
            }
            if(option==3)
            {
                Itemmenu.itemmenu= Itemmenu.itemmenu.OrderBy(o => o.price).ToList();
                Console.WriteLine("{0}\t{1}\t{2}", Itemmenu.itemmenu.First().name, Itemmenu.itemmenu.First().type, Itemmenu.itemmenu.First().price);
            }
            Console.ReadKey();
        }
    }
}
