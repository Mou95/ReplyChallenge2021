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
            bestAntennaScore = -1;
        }

        public int positionX { get; set; }
        public int positionY { get; set; }
        public int latency { get; set; }
        public int speed { get; set; }
        public int internalScore { get; set; }
        public int bestAntennaScore { get; set; }

        //metodo che data antenna mi calcola il valore
        public int ScoreForAntenna(Antenna antenna, int positionX, int positionY) 
        {
            var distanza = DistanzaDa(positionX,positionY);
            var score = 0;

            if (distanza <= antenna.range)
            {
                score = this.speed * antenna.speed - this.latency * distanza;
            }

            return score;
        }

        //ritorna true se building coperto
        public bool IsBuilidingCovered()
        {
            return bestAntennaScore != -1;
        }

        public int DistanzaDa(int x, int y)
        {
            return Utilities.Utilities.Distanza(x, y, this.positionX, this.positionY);
        }
    }
}
