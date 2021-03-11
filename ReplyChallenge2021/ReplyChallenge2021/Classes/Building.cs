using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyChallenge2021.Classes
{
    public class Building
    {
        public Building(int x, int y, int l, int s)
        {
            positionX = x;
            positionY = y;
            latency = l;
            speed = s;
        }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int latency { get; set; }
        public int speed { get; set; }


        public int DistanzaDa(int x, int y)
        {
            return Utilities.Utilities.Distanza(x, y, this.positionX, this.positionY);
        }
    }
}
