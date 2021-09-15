using System;
using System.Collections.Generic;
using System.Threading;
namespace snake_ladder
{
    class Program
    {



 public static int Main(String[] args)
   {

            board b = new board(); 
            player player1 = new player();    // creationg objects of player  and board class. 

            Console.WriteLine( "\n****************************************************************************\n");

            Console.WriteLine("\t\tSnakes and Ladder Board");
            Console.WriteLine("\n****************************************************************************\n");
            
         

            Console.WriteLine("\n**************************************************************************\n");

            Console.WriteLine( "***********************Dice score***********************\n");
            int score;
            while (true)
            {
                // player part.
                player1.previousposition = player1.currentposition;
                score = player1.Rolling_dice();   // calling Rolling_dice function. 

                player1.currentposition = b.nextposition(score, player1.previousposition);
                if (player1.currentposition > 100)
                   player1.currentposition = player1.previousposition;
                
                Console.WriteLine("Previous Position :\t" + player1.previousposition);
                Console.WriteLine(  "\nDice score     :\t"+score  );
                Console.WriteLine("\nCurrent Position :\t" + player1.currentposition);
                Console.WriteLine("------------------------------------------------------------------------");

                if (player1.currentposition == 100)
                {
                    Console.WriteLine(" Player won the Game "  );
                    break;
                }
                
            }
            Thread.Sleep(2000);
            return 1;
        }


    }

    }
