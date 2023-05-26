using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02.DL
{
    class gameobj
    {
        public static void Shape(ref char x,ref char y,ref char z)
        {
            Console.WriteLine("Enter the three characters of the shape:");
            x = char.Parse(Console.ReadLine());
            y = char.Parse(Console.ReadLine());
            z = char.Parse(Console.ReadLine());
        }
        public static void get_direction(ref int option)
        {
            Console.WriteLine("1.LefttoRight");
            Console.WriteLine("2.RighttoLeft");
            Console.WriteLine("3.Patrol");
            Console.WriteLine("4.Diagonal");
            Console.WriteLine("5.Projectile");
            option = int.Parse(Console.ReadLine());
        }
    }
}
