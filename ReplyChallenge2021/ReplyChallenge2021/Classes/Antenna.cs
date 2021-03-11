using System;
using System.Linq;
using System.Collections.Generic;

namespace ReplyChallenge2021.Classes
{
    public class Antenna
    {
        public Antenna(int id, int r, int s, int valueRange, int valueSpeed)
        {
            this.id = id;
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
        // Ritorna score per ogni building coperto, e sommare il valore al totale solo se building.bestValoreAntenna < valore dato dall'antenna per cui sto facendo il calcolo
        public int calculateScore(City city, Tuple points, List<Building> buildings)
        {
            
            int x = point.Item1;
            int y = point.Item2;

            if (city.positionAntenne[x, y] > 0)
            {
                return;
            }

            int totalScore = 0;

            foreach (Building building in buildings)
            {

                int score = building.ScoreForAntenna(this, x, y);
                if (score > 0 && score > building.bestAntennaScore)
                {
                    totalScore = totalScore + score;
                }
            }

            return totalScore;
        }
    }
}