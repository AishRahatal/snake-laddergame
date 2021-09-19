using System;
using System.Collections.Generic;
using System.Threading;
namespace snake_ladder
{
    class Program
     {
          // UC1 for single player


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
            int count =0;
            while (true) // UC4- Repeat till the Player reaches the winning position 100.
            {
                // player part.
                player1.previousposition = player1.currentposition;
                score = player1.Rolling_dice();   // calling Rolling_dice function. 
                 count++;
                player1.currentposition = b.nextposition(score, player1.previousposition);
                if (player1.currentposition > 100)
                   player1.currentposition = player1.previousposition;
                
                // UC6-Report the number of times the dice was played to win the game and also the position after every die role
                Console.WriteLine(" Player1 : "+player1.name + "\t||  No of time dice roll :"+count);
                Console.WriteLine("Previous Position :\t" + player1.previousposition);
                Console.WriteLine(  "\nDice score     :\t"+score  ); 
                Console.WriteLine("\nCurrent Position :\t" + player1.currentposition);
                Console.WriteLine("------------------------------------------------------------------------");

                if (player1.currentposition == 100) //UC5- Ensure the player gets to exact winning position 100.
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
