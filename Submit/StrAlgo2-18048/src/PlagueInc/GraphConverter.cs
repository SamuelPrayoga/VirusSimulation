using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagueInc
{
    class GraphConverter
    {
        public static Microsoft.Msagl.Drawing.Graph graphConverter(Graph graph)
        {
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graphOut = new Microsoft.Msagl.Drawing.Graph("graph");

            //create the graph content 
            foreach (var src in graph.getGraph())
            {
                // Add edge
                foreach (var dst in src.Value)
                {
                    if (graph.getEdgeInfected().ContainsKey(src.Key))
                    {
                        if (graph.getEdgeInfected()[src.Key].Contains(dst.Item1))
                        {
                            graphOut.AddEdge(src.Key, dst.Item1).Attr.Color = Microsoft.Msagl.Drawing.Color.IndianRed;
                            continue;
                        }
                    }
                    graphOut.AddEdge(src.Key, dst.Item1);
                }
                // Change default shape
                graphOut.FindNode(src.Key).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }

            // Add color to infected city
            foreach (var node in graph.getTimeInfected())
            {
                if (node.Value != int.MaxValue)
                    graphOut.FindNode(node.Key).Attr.FillColor = Microsoft.Msagl.Drawing.Color.IndianRed;
                else
                    graphOut.FindNode(node.Key).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightGreen;
            }

            return graphOut;
        }
    }
}
