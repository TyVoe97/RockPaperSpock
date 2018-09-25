using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human : Player
    {
        public override void SetChoiceGesture()
        {
            Console.WriteLine("Press 1 for Rock , Press 2 for Paper , 3 for Scissors , 4 for Lizzard , and 5 for Spock.");
            gesture = int.Parse(Console.ReadLine());
        }
        public override void SetName()
        {
            Console.WriteLine("Whats your name ");
            name = Console.ReadLine();
        }




    }

    }

