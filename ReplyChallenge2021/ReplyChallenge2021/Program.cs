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
            City city = ReadFile.ReadInputFile("data_scenarios_a_example.in", 1, 1, 9, 1);

            int av = city.AvarageAntennasRange();
            List<Building> val = city.BuildingInsideRange(av, 11, 7);

            int finalScore = city.CalculateScore();
            
        }
    }
}
