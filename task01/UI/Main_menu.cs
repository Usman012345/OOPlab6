using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01.UI
{
    class Main_menu
    {
        public static int main_menu()
        {
            Console.WriteLine("1.Add a menu item");
            Console.WriteLine("2.View the cheapest item on the menu");
            Console.WriteLine("3.View the drinks menu");
            Console.WriteLine("4.View the foods menu");
            Console.WriteLine("5.Add order");
            Console.WriteLine("6.Fullfil the order");
            Console.WriteLine("7.View the order's list");
            Console.WriteLine("8.Total payable amount");
            Console.WriteLine("0.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
