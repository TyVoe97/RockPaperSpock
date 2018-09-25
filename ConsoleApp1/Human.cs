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
            Console.WriteLine("Press 1 for Rock");
            gesture = int.Parse(Console.ReadLine());
        }
        public override void SetName()
        {
            Console.WriteLine("Whats your name ");
            name = Console.ReadLine();
        }




    }

    }

