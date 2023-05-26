using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02.UI
{
    class menu
    {
        public static void menu_(ref int option)
        {
            Console.WriteLine("1.Decide starting point: ");
            Console.WriteLine("2.Decide premises: ");
            Console.WriteLine("3.Chose direction:");
            Console.WriteLine("4.Change shape:");
            Console.WriteLine("5.Move: ");
            Console.WriteLine("6.Erase: ");
            Console.WriteLine("7.Draw: ");
            Console.WriteLine("8.Load previous Starting point,direction and general premises:");
            Console.WriteLine("0.Exit");
            option = int.Parse(Console.ReadLine());
        }
    }
}
