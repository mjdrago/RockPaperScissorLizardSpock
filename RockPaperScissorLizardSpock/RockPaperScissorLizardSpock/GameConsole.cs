﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class GameConsole
    {
        public Player player1;
        public Player player2;
        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Is this a two-player or one-player game? \n" +
                              "Please enter '1' for one-player game or '2' for a two-player game.");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    player1 = new Human("Player One");
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new Human("Player One");
                    player2 = new Human("Player Two");
                    break;
                default:
                    Console.WriteLine("Invalid choice selected. Please try again");
                    GetNumberOfPlayers();
                    break;
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine(
                    "Rules for Rock, Paper, Scissors, Lizard, Spock: \n" +
                    " - Scissors cuts Paper \n" +
                    " - Paper covers Rock \n" +
                    " - Rock crushes Lizard \n" +
                    " - Lizard poisons Spock \n" +
                    " - Spock smashes Scissors \n" +
                    " - Scissors decapitates Lizard \n" +
                    " - Lizard eats Paper \n" +
                    " - Paper disproves Spock \n" +
                    " - Spock vaporizes Rock \n" +
                    " - (and as it always has) Rock crushes Scissors \n");
        }
        public void DeclareRoundWinner(Player winner,Player loser)
        {
            if (winner.typeOfPlayer == "computer")
            {
                Console.WriteLine("{0} you lost this round!", loser.name);
            }
            else
            {
                Console.WriteLine("{0} you won this round!", winner.name);
            }
        }
        public void CompareWeapons()
        {
            int numberOfWeapons = 5;
            int decisionModulus = ((numberOfWeapons + player1.currentSelection - player2.currentSelection) % 5) % 2;
            if (decisionModulus == 0)
            {
                DeclareRoundWinner(player1, player2);
                player1.numberOfRoundWins++;
            }
            else
            {
                DeclareRoundWinner(player2, player1);
                player2.numberOfRoundWins++;
            }
        }

        public void DisplayGameWinner(Player winner,Player loser)
        {
            if (winner.typeOfPlayer == "computer")
            {
                Console.WriteLine("{0} you lost the game.", loser.name);
            }
            else
            {
                Console.WriteLine("{0} you won the game!",winner.name);
            }
        }
        public void DetermineGameWinner()
        {
            if (player1.numberOfRoundWins == 2)
            {
                DisplayGameWinner(player1, player2);
            }
            else
            {
                DisplayGameWinner(player2, player1);
            }
        }
        public void AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? Enter 'yes' or 'no'.");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "yes":
                    PlayGame();
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("That was not a valid entry. Please try again.");
                    AskToPlayAgain();
                    break;
            }
        }
        public void PlayGame()
        {
            GetNumberOfPlayers();
            DisplayRules();
            while (player1.numberOfRoundWins != 2 && player2.numberOfRoundWins != 2)
            {
                player1.ChooseWeapon();
                player2.ChooseWeapon();
                if (player1.currentSelection == player2.currentSelection)
                {
                    Console.WriteLine("You tied! Choose again!");
                }
                else
                {
                    CompareWeapons();
                }
            }
            DetermineGameWinner();
            AskToPlayAgain();
        }
    }
}
