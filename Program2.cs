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
            player player1 = new player();
            player player2 = new player();// creationg objects of player  and board class. 

            Console.WriteLine( "\n****************************************************************************\n");

            Console.WriteLine("Snakes and Ladder Board");
            Console.WriteLine("\n****************************************************************************\n");

            Console.WriteLine(" Enter payer1 name");
            player1.name = Console.ReadLine();
            Console.WriteLine(" Enter payer2 name");
            player2.name = Console.ReadLine();



            Console.WriteLine("\n**************************************************************************\n");

            Console.WriteLine( "***********************Dice score***********************\n");
            int score;
            while (true)
            {
                // player1 
                player1.previousposition = player1.currentposition;
                score = player1.Rolling_dice();   // calling Rolling_dice function. 

                player1.currentposition = b.nextposition(score, player1.previousposition);
                if (player1.currentposition > 100)
                   player1.currentposition = player1.previousposition;
                Console.WriteLine(" Player1 : "+player1.name);
                Console.WriteLine("Previous Position :\t" + player1.previousposition);
                Console.WriteLine(  "\nDice score     :\t"+score  );
                Console.WriteLine("\nCurrent Position :\t" + player1.currentposition);
                Console.WriteLine("------------------------------------------------------------------------");

                if (player1.currentposition == 100)
                {
                    Console.WriteLine(" Player1 won the Game :"+player1.name );
                    break;
                }

                // player2 
                player2.previousposition = player2.currentposition;
                score = player2.Rolling_dice();   // calling Rolling_dice function. 

                player2.currentposition = b.nextposition(score, player2.previousposition);
                if (player2.currentposition > 100)
                    player2.currentposition = player2.previousposition;
                Console.WriteLine(" Player2 : "+player2.name);
                Console.WriteLine("Previous Position :\t" + player2.previousposition);
                Console.WriteLine("\nDice score     :\t" + score);
                Console.WriteLine("\nCurrent Position :\t" + player2.currentposition);
                Console.WriteLine("------------------------------------------------------------------------");

                if (player2.currentposition == 100)
                {
                    Console.WriteLine(" Player2 won the Game :"+player2.name);
                    break;
                }

            }
            Thread.Sleep(2000);
            return 1;
        }


    }

    }

