using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int score = 0;
            
          //  int x;
           // int y; // x and y is location

           // int weapon; //player weapon

           // string title = "Coolest Game Ever";
            Console.WriteLine("Single-dimensional Arrays");
            Console.WriteLine();

           // int maxPlayers = 4;

          //  int[] score = new int[4];
          //  int[] x = new int[4];
           // int[] y = new int[4];
           // int[] weapon = new int[4];

           // for (int player = 0; player < maxPlayers; player++)
           // {
           //     Console.WriteLine("===================");
            //    Console.WriteLine("Player #" + (player + 1) + ": ");
           //    Console.WriteLine("- Score:" + score[player]);
           //     Console.WriteLine("- Weapon:" + weapon[player]);
            //    Console.WriteLine("- Location: (" + x[player] + "," + y[player] + ")");
            //    Console.WriteLine("===================");
            //    Console.WriteLine();
          //  }


            //init. scores to 0
            //init. player locations to something??
            //init. player weapons to 0


            Console.WriteLine("Multi-dimensional Arrays");
            Console.WriteLine();

            //2D inventory system

            //single item example
            string currentItem;
            currentItem = "Pick-Axe";

            //hot bar (1D array) example

            string[] hotbar = new string[9];
            {
                hotbar[0] = "pickaxe";
                hotbar[1] = "axe";
                hotbar[2] = "shovel";
                hotbar[3] = "sword";
                hotbar[4] = "hoe";
                hotbar[5] = "bow";
                hotbar[6] = "arrow";
                hotbar[7] = "empty";
                hotbar[8] = "empty";
            }

            //NOW the 2D inventory
            //1D: string[] hotbar = new string[9];
            //hotbar [_]
            //2D: string[,] inventory = new string[9, 3];
            //inventory [_,_]
            string[,] inventory = new string[9, 3]; // (9x3)
            inventory[0,0] = "";
            //...
            inventory[4, 2] = "fart";
            //...
            inventory[8, 2] = "";

            //how to we init. all inventory slots to empty string ("") ?

            for (int x = 0; x <= 8; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    //Console.WriteLine(x + "," + y);
                    inventory[x,y] = "";
                    Console.WriteLine("Inventory[" + x + "," + y + "] = " + inventory[x,y]);
                }
            }

            Console.ReadKey(true);
        }
    }
}
