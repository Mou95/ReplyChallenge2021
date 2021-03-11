using ReplyChallenge2021.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyChallenge2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //primo commmento di mauro
            string filename = "data_scenarios_f_tokyo.in";
            City city = ReadFile.ReadInputFile(filename, 1, 5, 9, 1);

            int av = city.AvarageAntennasRange();

            //Ordinare punti mappa
            List<Tuple<int,int,int>> listOfPointsOrdered = new List<Tuple<int,int,int>>();

            Console.WriteLine("1");

            city.antennas = city.antennas.OrderBy(a => a.speed).ToList();
            city.buildings = city.buildings.OrderBy(b => b.speed).ToList();


            for (int i = 0; i < city.antennas.Count(); i++)
            {
                city.antennas[i].bestX = city.buildings[i].positionX;
                city.antennas[i].bestY = city.buildings[i].positionY;
            }

            //for (int x = 0; x <= city.width ; x++)
            //{
            //    for (int y = 0; y <= city.heigth ; y++)
            //    {
            //        //List<Building> buildings = city.BuildingInsideRange(av, x, y);
            //        //var pointValue = 0;

            //        //pointValue = buildings.Sum(building => building.internalScore);

            //        listOfPointsOrdered.Add(new Tuple<int,int,int>(x,y,0));
            //    }
            //}

            //Console.WriteLine("2");

            ////Lista ordinata
            ////IEnumerable<Tuple<int,int,int>> listOfPointsOrdered = listOfPoints.OrderBy(point => point.Item3);

            //IEnumerable<Antenna> antennasOrdered = city.antennas.OrderBy(antenna => antenna.internalValue);

            //Console.WriteLine("3");

            //foreach (Antenna antenna in antennasOrdered)
            //{
            //    Console.WriteLine(antenna.id);
            //    int bestX = -1;
            //    int bestY = -1;
            //    int bestScore = -1;
            //    foreach(Tuple<int,int,int> point in listOfPointsOrdered)
            //    {
            //        List<Building> buildings = city.BuildingInsideRange(av, point.Item1, point.Item2);
            //        var singolarScore = antenna.CalculateScore(city, point, buildings);
                    

            //        if (singolarScore > bestScore)
            //        {
            //            bestX = point.Item1;
            //            bestY = point.Item2;
            //            bestScore = singolarScore;
            //        }
            //    }

            //    //Assegno antenna e aggiorno mappa città
            //    antenna.bestX = bestX;
            //    antenna.bestY = bestY;
            //    antenna.bestScore = bestScore;
            //    city.positionAntenne[bestX, bestY] = 1;

            //    //Aggiorno buildings
            //    foreach(Building b in city.BuildingInsideRange(av, bestX, bestY))
            //    {
            //        var scoreForAntenna = b.ScoreForAntenna(antenna, bestX, bestY);
            //        if (b.bestAntennaScore < scoreForAntenna)
            //        {
            //            b.bestAntennaScore = scoreForAntenna;
            //        }
            //    }
            //}

            //int finalScore = city.CalculateScore();

            ReadFile.WriteOutputFile("out-" + filename, city);
            
        }
    }
}
