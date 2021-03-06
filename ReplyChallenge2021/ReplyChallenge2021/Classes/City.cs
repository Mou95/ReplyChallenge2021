using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyChallenge2021.Classes
{
    public class City
    {
        public City(int w, int h, int r, List<Antenna> a, List<Building> b)
        {
            width = w;
            heigth = h;
            reward = r;
            antennas = a;
            buildings = b;

            positionAntenne = new int[w + 1, h + 1];
        }

        public List<Antenna> antennas { get; set; }
        public List<Building> buildings { get; set; }
        public int width { get; set; }
        public int heigth { get; set; }
        public int reward { get; set; }

        //campo matrice con 0 dove non ci sono le antenne e 1 dove ci sono
        public int[,] positionAntenne { get; set; }

        //calcolo totale punteggio finale -> somma di tutti i  bestscore dei building + reward (con condizione)
        public int CalculateScore() => (reward*IsAllBuildingsCovered()) + buildings.Sum(x => x.bestAntennaScore);

        //metodo che date x,y e range ritorna building dentro al range
        public List<Building> BuildingInsideRange(int range, int positionX, int positionY)
        {
            List<Building> result = new List<Building>();

            int max = range / 2;
            int maxX = positionX + max;
            int minX = positionX - max;
            int maxY = positionY + max;
            int minY = positionY - max;
            result = this.buildings.Where(b => b.positionX <= maxX && b.positionX >= minX && b.positionY <= maxY && b.positionY >= minY).ToList();

            List<Building> output = new List<Building>();
            foreach (Building b in result)
            {
                int distance = b.DistanzaDa(positionX, positionY);
                if (distance <= range) output.Add(b);
            }

            return output;
        }

        public int IsAllBuildingsCovered()
        {
            if (buildings.FirstOrDefault(b => b.bestAntennaScore == -1) != null) return 0;
            return 1;
        }

        public int AvarageAntennasRange()
        {
            int sum = 0;
            
            sum = antennas.Sum(x => x.range);

            int average = sum/antennas.Count;
            return average;
        }
    }
}
