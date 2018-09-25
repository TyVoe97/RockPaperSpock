using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        public abstract class Player
        {
            public string name;
            public int gesture;
            public int score;

            public abstract void SetChoiceGesture();

            public abstract void SetName();
        }
}


