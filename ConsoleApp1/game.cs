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
        

       public void Score()
        {
          if(player1.gesture > player2.gesture)
            {
                Console.WriteLine( 1 );
            }
            else if(player2.gesture > player1.gesture)
            {
                Console.WriteLine(1);
            }
            else if( player1.gesture == player2.gesture)
            {
                Console.WriteLine(0);
            }

           
        }
        
        public void Round()
        {
            GetPlayerGestures();
            CompareGestures();
            Score();
            //SetPlayers();
            for (int CompareGestures = 1; CompareGestures > 3; CompareGestures++)
            {
                if (CompareGestures == 3)
                {
                    Console.WriteLine("End of Round");
                    Console.ReadLine();
                }
            }


            Console.WriteLine("Press enter to continue");
                    Console.ReadLine();


            Round();
        }

        //METHODS
        //Get number of players
        //Get player objects
        //Get player gestures
        //Compare player gestures
        //Get rounds 
        //Get score 
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

            player1.SetName();
            player2.SetName();
            Round();
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
                Console.WriteLine(player2.name + " has beat you Paper covers rock!");
                
            }
            if (player1.gesture == 1 && player2.gesture == 1)
            {
                Console.WriteLine( " You both won it's a tie");
            }
            if (player1.gesture == 1 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " has wone Rock crushes Scissors!");

            }
            if (player1.gesture == 1 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + "  has won Rock crushes Lizard!");
            }
            if (player1.gesture == 1 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + " has won Spock vaporizes Rock!");
            }
            if (player1.gesture == 2 && player2.gesture == 1)
            {
                Console.WriteLine(player1.name + " has won Paper covers Rock!");
            }
            if (player1.gesture == 2 && player2.gesture == 2)
            {
                Console.WriteLine(" You both win its a tie, Paper can't beat Paper it only stacks");
            }
            if (player1.gesture == 2 && player2.gesture == 3)
            {
                Console.WriteLine(player2.name + " has won Scissors cuts Paper !");
            }
            if (player1.gesture == 2 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " has won Lizard eats Paper!");
            }
            if (player1.gesture == 2 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " has won Paper disapproves of Spock !");

            }
            if (player1.gesture == 3 && player2.gesture == 1)
            {
                Console.WriteLine(player2.name + " has won Rock crushes Scissors!");
            }
            if (player1.gesture == 3 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + " has won Scissors cuts Paper!");
            }
            if (player1.gesture == 3 && player2.gesture == 3)
            {
                Console.WriteLine("You both win, Its a tie ");
            }
            if (player1.gesture == 3 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + " has won Scissors decapitates Lizard!");
            }
            if (player1.gesture == 3 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + "  has won Spock smashes Scissors!");
            }
            if (player1.gesture == 4 && player2.gesture == 1)
            {
                Console.WriteLine(player2.name + " has won Rock crushes Lizard!");
            }
            if (player1.gesture == 4 && player2.gesture == 2)
            {
                Console.WriteLine(player1.name + "has won Lizard eats Paper");
            }
            if (player1.gesture == 4 && player2.gesture == 3)
            {
                Console.WriteLine(player2.name + " has won Scissors decapitates Lizard!");
            }
            if (player1.gesture == 4 && player2.gesture == 4)
            {
                Console.WriteLine(" You both win, Its a tie Lizards are friends!");
            }
            if (player1.gesture == 4 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " has won Lizard poisons Spock!");
            }
            if (player1.gesture == 5 && player2.gesture == 1)
            {
                Console.WriteLine(player2.name + " has won Spock Vaporizes Rock!");
            }
            if (player1.gesture == 5 && player2.gesture == 2)
            {
                Console.WriteLine(player2.name + " has won Paper disaproves Spock ");
            }
            if (player1.gesture == 5 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " has won Paper disaproves Spock!");
            }
            if (player1.gesture == 5 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " has won Lizard poisons Spcock!");
            }
            if (player1.gesture == 5 && player2.gesture == 5)
            {
                Console.WriteLine( " You both won Spock is freinds with Spock!");

            }

        
        }
       
    }
}

