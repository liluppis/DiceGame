using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class PlayGame
    {
        private Player player1;
        private Player player2;
        private readonly Random randomNumber = new Random();
        private bool isGameDone = false; // to break while-loop

        /*public PlayGame()
        {
            // to start game
        }*/

        private void IntroduceAndAskForPlayerNames()
        {
            Console.WriteLine("Hi and welcome to the Dice Game!");
            Console.WriteLine("Dice Game is a two-player game. The player with the highest score wins!");
            
            // creating player one 
            string askForPlayerOne = "Please enter Player 1: ";
            string userName1 = InputHelper.ReadString(askForPlayerOne);
            this.player1 = new Player(userName1, 0);

            // creating player two
            string askForPlayerTwo = "Please enter Player 2: ";
            string userName2 = InputHelper.ReadString(askForPlayerTwo);
            this.player2 = new Player(userName2, 0);

            Console.WriteLine("Hi " + player1 + " and " + player2 + "! Let's play :)");

        }

        private void RollTheDice(Player player)
        {
            Console.WriteLine("Press ENTER to roll the dice, " + player);
            Console.ReadLine();

            // limit which numbers to be randomized 
            int roll = randomNumber.Next(6) + 1;
            Console.WriteLine(player + " threw: " + roll);
            player.addScore(roll); // update player score 
        }

        private void DetermineWinner()
        {

            if (player1.GetScore() > player2.GetScore())
            {
                Console.WriteLine(player1.GetUserName() + " got " + player1.GetScore() + " points");
                Console.WriteLine(player2.GetUserName() + " got " + player2.GetScore() + " points");
                Console.WriteLine(player1.GetUserName() + " won!");
                PlayAgain();
            }

            else if (player2.GetScore() > player1.GetScore())
            {
                Console.WriteLine(player2.GetUserName() + " got " + player2.GetScore() + " points");
                Console.WriteLine(player1.GetUserName() + " got " + player1.GetScore() + " points");
                Console.WriteLine(player2.GetUserName() + " won");
                PlayAgain();
            }

            else
            {
                Console.WriteLine(player1.GetUserName() + " got " + player1.GetScore() + " points");
                Console.WriteLine(player2.GetUserName() + " got " + player2.GetScore() + " points");
                Console.WriteLine("It's a tie!");
                PlayAgain();
            }
        }

        private void PlayAgain()
        {
            // alternatives for user to choose between
            Console.WriteLine("1. Play again?");
            Console.WriteLine("2. Exit game");

            // reading user's choice 
            int choice = InputHelper.ReadInt("> ");


            // switch to handle user choice 
            switch (choice)
            {
                case 1:
                    StartAndPlayGame();
                    break;
                
                case 2:
                    isGameDone = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }



        }

        public void StartAndPlayGame()
        {
            IntroduceAndAskForPlayerNames();

            while(!isGameDone)
            {
                RollTheDice(player1);
                RollTheDice(player2);
                RollTheDice(player1);
                RollTheDice(player2);
                DetermineWinner();

            }
        }















    }
}
