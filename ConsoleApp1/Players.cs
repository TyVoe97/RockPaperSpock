using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Players
    {
        public string firstname;
        public string lastname;
        public string nickname;

        public Players()
        {
        }

        public Players(string firstname, string lastname, string nickname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.nickname = nickname;
        }
        

    }
}
