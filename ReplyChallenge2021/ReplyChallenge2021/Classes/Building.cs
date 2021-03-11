using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyChallenge2021.Classes
{
    public class Building
    {

        public Building(int x, int y, int l, int s, int valueConnection, int valueLatency)
        {
            positionX = x;
            positionY = y;
            latency = l;
            speed = s;

            internalScore = valueConnection * speed - valueLatency * latency;
            bestAntennaScore = 0;
        }

        public int positionX { get; set; }
        public int positionY { get; set; }
        public int latency { get; set; }
        public int speed { get; set; }
        public int internalScore { get; set; }
        public int bestAntennaScore { get; set; }

        //metodo che data antenna mi calcola il valore

        //ritorna true se building coperto

        //metodo che date x,y e range ritorna building dentro al range
    }
}
