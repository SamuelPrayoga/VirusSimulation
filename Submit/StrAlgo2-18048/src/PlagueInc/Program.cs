using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueInc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* TEST 1
            Graph g = new Graph();
            g.addEdge("0", "1", 4);
            g.addEdge("0", "2", 2);
            g.addEdge("1", "2", 1);
            g.addEdge("1", "3", 5);
            g.addEdge("2", "3", 8);
            g.addEdge("2", "4", 10);
            g.addEdge("3", "4", 2);
            g.addEdge("3", "5", 6);
            g.addEdge("4", "5", 3);
            System.Console.WriteLine(g);
            */

            /* TEST 2
            //create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //bind the graph to the viewer 
            viewer.Graph = graphOut;
            associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            show the form 
            form.ShowDialog();
             */
            /*
           // Initial setup
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);

           // Generate graph
           string fp1 = @"J:\Jovan's Stuff\ITB\IF04\IF4-Tubes\Tubes2Stima-PlagueInc\test1.txt";
           string fp2 = @"J:\Jovan's Stuff\ITB\IF04\IF4-Tubes\Tubes2Stima-PlagueInc\test2.txt";
           //string fp2 = @"E:\KULIAH\SEMESTER 4\Strategi Algoritma\Tubes 2\Tubes2Stima-PlagueInc\test2.txt";
           Graph g = FileReader.readGraphFromFile(fp1, fp2);
           System.Console.WriteLine(g); // console out

           // Convert graph
           Microsoft.Msagl.Drawing.Graph gDraw = GraphConverter.graphConverter(g);

           // Draw graph
           // Create viewer object 
           Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
           // Bind graph and viewer
           viewer.Graph = gDraw;
           // Add dockstyle
           viewer.Dock = System.Windows.Forms.DockStyle.Fill;
           */

            // Initial setup
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Add viewer to Form
            System.Windows.Forms.Form app = new Frontend();
            
            // Run
            Application.Run(app);

            /*
            string mapFilePath = @"E:\KULIAH\SEMESTER 4\Strategi Algoritma\Tubes 2\Tubes2Stima-PlagueInc\test1.txt";
            string popFilePath = @"E:\KULIAH\SEMESTER 4\Strategi Algoritma\Tubes 2\Tubes2Stima-PlagueInc\test2.txt";
            Graph g = FileReader.readGraphFromFile(mapFilePath, popFilePath);
            g.setInputTime(1);
            g.BFS(g.getViralSource());
            GraphConverter.graphConverter(g);
            */
        }
    }
}
