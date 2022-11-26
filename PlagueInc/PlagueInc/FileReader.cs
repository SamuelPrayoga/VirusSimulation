using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagueInc
{
    class FileReader
    {
        public static Graph readGraphFromFile(string filePath1, string filePath2)
        {
            Graph g = new Graph();
            mapSetup(ref g, filePath1);
            populationSetup(ref g, filePath2);
            return g;
        }
        private static void mapSetup(ref Graph g, string filePath1)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath1);
                for (int i = 1; i <= Convert.ToInt32(lines[0]); i++)
                {
                    string[] line = lines[i].Split(' ');
                    g.addEdge(line[0], line[1], Convert.ToDouble(line[2].Replace('.', ',')));
                }
            } catch (System.IO.FileNotFoundException)
            {
                throw new System.InvalidOperationException("Map file not found.");
            }
        }
        private static void populationSetup(ref Graph g, string filePath2)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath2);
                g.setViralSource(lines[0].Split(' ')[1]);
                for (int i = 1; i <= Convert.ToInt32(lines[0].Split(' ')[0]); i++)
                {
                    string[] line = lines[i].Split(' ');
                    g.setPopulation(line[0], Convert.ToInt32(line[1]));
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new System.InvalidOperationException("Population file not found.");
            }
        }
    }
}
