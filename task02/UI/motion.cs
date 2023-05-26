using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using task02.BL;
using EZInput;
using Unity;
namespace task02.UI
{
    class motion
    {
        public motion()
        {
            if (Gameobject.direction == "LefttoRight")
            {
                if (Gameobject.start.X < Gameobject.topright.X)
                {
                    foreach (char data in Gameobject.obj)
                    {
                        Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                        Console.Write(data);

                        if (Gameobject.start.X > 3)
                        {
                            Console.SetCursorPosition(Gameobject.start.X - 3, Gameobject.start.Y);
                            Console.Write(" ");
                        }
                        Gameobject.start.X++;

                        Thread.Sleep(200);
                    }
                }
            }
            if(Gameobject.direction == "RighttoLeft")
            {
                    if (Gameobject.start.X > Gameobject.topleft.X)
                    {
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X + 3, Gameobject.start.Y);
                                Console.Write(" ");
                            }
                            Gameobject.start.X--;

                            Thread.Sleep(100);
                        }
                    }
                
            }
            if (Gameobject.direction == "Patrol")
            {
                bool left = true;
                do
                {
                    if (Gameobject.start.X < Gameobject.topright.X && left==true)
                    {
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X - 3, Gameobject.start.Y);
                                Console.Write(" ");
                            }
                            Gameobject.start.X++;  
                        }
                    }
                   else if (Gameobject.start.X > Gameobject.topleft.X)
                    {
                        left = false;
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X + 3, Gameobject.start.Y);
                                Console.Write(" ");
                            }
                            Gameobject.start.X--;
                        }
                        if (Gameobject.start.X == Gameobject.topleft.X)
                            Console.SetCursorPosition(Gameobject.start.X -1, Gameobject.start.Y);
                        Console.Write(" ");
                        left = true;
                    }
                    Thread.Sleep(200);
                } while (!(EZInput.Keyboard.IsKeyPressed(Key.Escape)));
            }
            if (Gameobject.direction == "Diagonal")
            {
                do
                {
                    if (Gameobject.start.X < Gameobject.bottomright.X && Gameobject.start.Y < 30)
                    {
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X-5, Gameobject.start.Y-1);
                                Console.Write(" ");
                            }
                            Gameobject.start.X+=5;
                            Gameobject.start.Y++;

                            Thread.Sleep(200);
                        }
                    }
                } while (!(EZInput.Keyboard.IsKeyPressed(Key.Escape)));
            }
            if(Gameobject.direction == "Projectile")
            {
                for (int x = 0; x < 5; x++)
                {
                    if (Gameobject.start.X < Gameobject.bottomright.X && Gameobject.start.Y >0)
                    {
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);
                        }

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X - 3, Gameobject.start.Y + 1);
                                Console.Write(" ");
                            }
                            Gameobject.start.X+=3;
                            Gameobject.start.Y--;
                        if (x == 4)
                            Console.Clear();

                            Thread.Sleep(200);
                    }
                }
                for(int x=0;x<2;x++)
                {
                    if (Gameobject.start.X < Gameobject.topright.X)
                    {
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X - 3, Gameobject.start.Y);
                                Console.Write(" ");
                            }
                            Gameobject.start.X++;

                            Thread.Sleep(200);
                        }
                    }
                    if(x==1)
                    {
                        Console.Clear();
                    }
                }
                for(int x=0;x<4;x++)
                {
                    if (Gameobject.start.X < Gameobject.bottomright.X && Gameobject.start.Y < 30)
                    {
                        foreach (char data in Gameobject.obj)
                        {
                            Console.SetCursorPosition(Gameobject.start.X, Gameobject.start.Y);
                            Console.Write(data);
                        }

                            if (Gameobject.start.X > 3)
                            {
                                Console.SetCursorPosition(Gameobject.start.X - 3, Gameobject.start.Y - 1);
                                Console.Write(" ");
                            }
                        
                            Gameobject.start.X += 3;
                            Gameobject.start.Y++;

                        
                    }
                }

            }
                Console.ReadKey();
            
        }
    }
}
