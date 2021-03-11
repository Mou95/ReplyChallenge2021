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
        }

        public List<Antenna> antennas { get; set; }
        public List<Building> buildings { get; set; }
        public int width { get; set; }
        public int heigth { get; set; }
        public int reward { get; set; }

        //campo matrice con 0 dove non ci sono le antenne e 1 dove ci sono

        //calcolo totale punteggio finale -> somma di tutti i  bestscore dei building + reward (con condizione)



    }
}
