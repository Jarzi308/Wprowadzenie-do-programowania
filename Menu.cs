using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szubienica
{
    static class Menu
    {
        public static void startMenu()
        {
            Console.Title = "Menu";

            while (true)

            {
                Console.Clear();
                Console.WriteLine(">>>Wybierz opcje<<<");
                Console.WriteLine("Graj");
                Console.WriteLine("Wyjdź");

                ConsoleKeyInfo klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {


                    case ConsoleKey.D1:
                        Console.Clear(); Wisielec.gra(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D2:
                        Environment.Exit(0); break;
                    default: break;



                }
            }

        }
        
    }

}
