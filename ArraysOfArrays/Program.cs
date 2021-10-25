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

            string title = "Coolest Game Ever";
            Console.WriteLine("Single-dimensional Arrays");
            Console.WriteLine();

            int maxPlayers = 4;

            int[] score = new int[4];
            int[] x = new int[4];
            int[] y = new int[4];
            int[] weapon = new int[4];

            for (int player = 0; player < maxPlayers; player++)
            {
                Console.WriteLine("Player #" + (player + 1) + " Score: " + score[player]);
            }


            //init. scores to 0
            //init. player locations to something??
            //init. player weapons to 0


            Console.WriteLine("Multi-dimensional Arrays");
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
