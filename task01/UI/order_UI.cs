using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task01.DL;
using task01.BL;

namespace task01.UI
{
    class order_UI
    {
        public static List<int> order_()
        {
            
            int count = 1;
            foreach(Menu data in Itemmenu.itemmenu)
            {

                Console.WriteLine(count+"{0}\t{1}\t{2}", data.name, data.type, data.price);
                count++;
            }
            count = 1;
            Console.WriteLine("Enter no of items you want to enter: ");
          int no = int.Parse(Console.ReadLine());
            for(int x=0;x<no;x++)
            {
                foreach (Menu data in Itemmenu.itemmenu)
                {

                    Console.WriteLine(count + "{0}\t{1}\t{2}", data.name, data.type, data.price);
                    count++;
                }
              orderlist.orders.Add(int.Parse(Console.ReadLine()));
            }
            return orderlist.orders;
        }
        public static void fulfill_order(int option)
        {
            if(option==0)
            {
                Console.WriteLine("All orders have been fulfilled...");
            }
            int count = 1;
            if(option==1)
            {
               foreach(int data in orderlist.orders)
                {
                    foreach(Menu data_ in Itemmenu.itemmenu)
                    {
                        if(data==count)
                        {
                            Console.WriteLine("{0} is ready",data_.name);
                        }
                        count++;
                    }
                    count = 1;
                }
            }
            Console.ReadLine();
            orderlist.orders.Clear();
        }
        public static void View_orders_list()
        {
            int count = 1;
            foreach (int data in orderlist.orders)
            {
                foreach (Menu data_ in Itemmenu.itemmenu)
                {
                    if (data == count)
                    {
                        Console.WriteLine("{0}\t{1}", data_.name,data_.price);
                    }
                    count++;
                }
                count = 1;
            }
            Console.ReadKey();
           
        }
        public static void bill()
        {
            int total_bill = 0;
            int count = 1;
            foreach (int data in orderlist.orders)
            {
                foreach (Menu data_ in Itemmenu.itemmenu)
                {
                    if (data == count)
                    {
                        total_bill += data_.price;
                        Console.WriteLine("The total bill is {0}",total_bill);
                    }
                    count++;
                }
                count = 1;
            }
            Console.ReadKey();
        }
    }
}
