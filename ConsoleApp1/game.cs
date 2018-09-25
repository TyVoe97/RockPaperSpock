using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        //MEMBER VARIABLES
        Player player1;
        Player player2;
        List<string> gestures = new List<string>();

        //METHODS
        //Get number of players
        //Get player objects
        //Get player gestures
        //Compare player gestures

        public void SetPlayers()
        {
            Console.WriteLine("How many players?");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (userInput == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void GetPlayerGestures()
        {
            player1.SetChoiceGesture();
            player2.SetChoiceGesture();
        }
        public void CompareGestures()
        {
            //1 is Rock
            //2 is Paper
            //3 is Scissors
            //4 is lizzard
            //5 spock
            /*//*Rock crushes Scissors
            Scissors cuts Paper
                Paper covers Rock
                Rock crushes Lizard 
                Lizard poisons Spock 
                Spock smashes Scissors 
                Scissors decapitates Lizard
                Lizard eats Paper 
                Paper disproves Spock 
                Spock vaporizes Rock*/
            if (player1.gesture == 1 && player2.gesture == 2)
            {
                Console.WriteLine(player2.name + " Paper covers rock!");
            }
            if (player1.gesture == 1 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + player2.name + "tie");
            }
            if (player1.gesture == 1 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " Rock crushes Scissors!");
            }
            if (player1.gesture == 1 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " Rock crushes Lizard!");
            }
            if (player1.gesture == 1 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + " Spock vaporizes Rock!");
            }
            if (player1.gesture == 2 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + " Paper covers Rock!");
            }
            if (player1.gesture == 2 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + player2.name + "Paper can't beat Paper it only stacks");
            }
            if (player1.gesture == 2 && player2.gesture == 3)
            {
                Console.WriteLine(player2.name + " Scissors cuts Paper !");
            }
            if (player1.gesture == 2 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " Lizard eats Paper!");
            }
            if (player1.gesture == 2 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " Paper disapproves of Spock !");

            }

            if (player1.gesture == 3 && player2.gesture == 1)
            {
                Console.WriteLine(player2.name + " Rock crushes Scissors!");
            }
            if (player1.gesture == 3 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + " Scissors cuts Paper!");
            }
            if (player1.gesture == 3 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + player2.name + "Scissors can't cut Scissors");
            }
            if (player1.gesture == 3 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + " Scissors decapitates Lizard!");
            }
            if (player1.gesture == 3 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + " wins!");
            }
            if (player1.gesture == 4 && player2.gesture == 1)
            {
                Console.WriteLine(player2.name + " Rock crushes Lizard!");
            }
            if (player1.gesture == 4 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + "Lizard eats Paper");
            }
            if (player1.gesture == 4 && player2.gesture == 3)
            {
                Console.WriteLine(player2.name + " Scissors decapitates Lizard!");
            }
            if (player1.gesture == 4 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + player1.name + " Lizard can't do anyhting to a Lizard!");
            }
            if (player1.gesture == 4 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " Lizard poisons Spock!");
            }
            if (player1.gesture == 5 && player2.gesture == 1)
            {
                Console.WriteLine(player2.name + " Paper covers rock!");
            }
            if (player1.gesture == 5 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + player2.name + "tie");
            }
            if (player1.gesture == 5 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " Rock crushes Scissors!");
            }
            if (player1.gesture == 5 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " Rock crushes Lizard!");
            }
            if (player1.gesture == 5 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + " Spock vaporizes Rock!");
            }
        }
    }
}

