using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyChallenge2021.Classes
{
    public class Antenna
    {
        public Antenna (int id, int r, int s, int valueRange, int valueSpeed)
        {
            id = id;
            range = r;
            speed = s;

            internalValue = valueRange * range + valueSpeed * speed;

            bestX = -1;
            bestY = -1;

            bestScore = 0;
        }

        public int id { get; set; }
        public int range { get; set; }
        public int speed { get; set; }
        public int internalValue { get; set; }
        public int bestX { get; set; }
        public int bestY { get; set; }
        public int bestScore { get; set; }
        
        // Totale valore di building coperti data la posizione
        // Ritorna score per ogni building coperto, e sommare il valore al totale solo se buildiing.bestValoreAntenna < valore dato dall'antenna per cui sto facendo il calcolo


        //

    }
}
