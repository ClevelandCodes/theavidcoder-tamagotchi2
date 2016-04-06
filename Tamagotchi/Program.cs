﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{

    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi t = new Tamagotchi("Ray", "Female", 100, 100);

            while (t.GetFullness() > 0 && t.GetHappiness() > 0)
            {
                Console.WriteLine("Would you like to feed or pet {0}?", t.GetName());
                String action = Console.ReadLine();

                if (action == "feed")
                {
                    t.Feed();
                }
                else if (action == "pet")
                {
                    t.Pet();
                }
                else
                {
                    Console.WriteLine("You can't do that with " + t.GetName() + ". Please try again!");
                }
                t.DoStuff();
                {
                    Console.WriteLine("Ray's new stats are: ");
                    Console.WriteLine("Fullness: {0} | Happiness: {1}", t.GetFullness(), t.GetHappiness());
                }
            }
        }
    }
}
