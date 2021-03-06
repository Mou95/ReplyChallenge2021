using ReplyChallenge2021.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReplyChallenge2021
{
    public class ReadFile
    {
        public static City ReadInputFile(string filename, int valueRange, int valueSpeed, int valueConnection, int valueLatency)
        {
            string text = System.IO.File.ReadAllText(filename);
            string[] array = text.Split(new char[] { '\n' });

            //lettura della prima riga
            string [] dimensioni = array[0].Split(new char[] { ' ' });
            int w = 0; int h = 0; 
            Int32.TryParse(dimensioni[0], out w);
            Int32.TryParse(dimensioni[1], out h);

            //lettura seconda riga
            int n = 0, m = 0, r = 0;
            string [] dati = array[1].Split(new char[] { ' ' });
            Int32.TryParse(dati[0], out n);
            Int32.TryParse(dati[1], out m);
            Int32.TryParse(dati[2], out r);

            //lettura buildiungs
            List<Building> buildings = new List<Building>();
            for (int i = 2; i < n + 2; i++)
            {
                string [] build = array[i].Split(new char[] { ' ' });
                int x = 0, y = 0, l = 0, c = 0;
                Int32.TryParse(build[0], out x);
                Int32.TryParse(build[1], out y);
                Int32.TryParse(build[2], out l);
                Int32.TryParse(build[3], out c);
                buildings.Add(new Building(x, y, l, c, valueConnection, valueLatency));
            }

            //lettura antennas
            List<Antenna> antennas = new List<Antenna>();
            for (int i = 2 + n; i < n + m + 2; i++)
            {
                int id = i - n - 2;
                string[] antenna = array[i].Split(new char[] { ' ' });
                int r1 = 0, c = 0;
                Int32.TryParse(antenna[0], out r1);
                Int32.TryParse(antenna[1], out c);
                antennas.Add(new Antenna(id, r1, c, valueRange, valueSpeed));
            }

            return new City(w, h, r, antennas, buildings);
        }



        public static void WriteOutputFile(string filename, City city)
        {
            List<Antenna> antennaOutput = city.antennas.Where(x => x.bestX != -1 && x.bestY != -1).ToList();
            string output = antennaOutput.Count() + "\n";
            foreach (Antenna a in antennaOutput)
            {
                output = output + a.id + " " + a.bestX + " " + a.bestY + "\n";
            }

            StreamWriter sw = new StreamWriter(filename);
            sw.Write(output);
            sw.Close();
        }
    }
}
