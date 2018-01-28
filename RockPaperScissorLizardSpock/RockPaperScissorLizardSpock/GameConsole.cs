using System;
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
            char selection = char.Parse(Console.ReadLine());
            switch (selection)
            {
                case '1':
                    player1 = new Human("Player One");
                    player2 = new Computer();
                    break;
                case '2':
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
            if (player1.currentSelection == 1 && (player2.currentSelection == 3|| player2.currentSelection == 4))
            {
                DeclareRoundWinner(player1,player2);
                player1.numberOfWins++;
            }
            else if (player1.currentSelection == 2 && (player2.currentSelection == 1 || player2.currentSelection == 5))
            {
                DeclareRoundWinner(player1, player2);
                player1.numberOfWins++;
            }
            else if (player1.currentSelection == 3 && (player2.currentSelection == 2 || player2.currentSelection == 4))
            {
                DeclareRoundWinner(player1, player2);
                player1.numberOfWins++;
            }
            else if (player1.currentSelection == 4 && (player2.currentSelection == 5 || player2.currentSelection == 2))
            {
                DeclareRoundWinner(player1, player2);
                player1.numberOfWins++;
            }
            else if (player1.currentSelection == 5 && (player2.currentSelection == 3 || player2.currentSelection == 1))
            {
                DeclareRoundWinner(player1, player2);
                player1.numberOfWins++;
            }
            else
            {
                DeclareRoundWinner(player2, player1);
                player2.numberOfWins++;
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
            if (player1.numberOfWins == 2)
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
            while (player1.numberOfWins != 2 && player2.numberOfWins != 2)
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
