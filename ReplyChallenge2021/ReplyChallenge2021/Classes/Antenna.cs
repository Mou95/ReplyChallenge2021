using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyChallenge2021.Classes
{
    public class Antenna
    {
        public Antenna (int r, int s)
        {
            range = r;
            speed = s;
        }
        public int range { get; set; }
        public int speed { get; set; }
    }
}
