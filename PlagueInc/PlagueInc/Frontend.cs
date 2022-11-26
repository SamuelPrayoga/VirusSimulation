using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueInc
{
    public partial class Frontend : Form
    {
        string mapFilePath, popFilePath;
        public Frontend()
        {
            InitializeComponent();
            MaximizeBox = false;
            numericTimeSet.Maximum = 9999;
        }

        private void Frontend_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mapFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mapFilePath = mapFilePathInp.Text = openFileDialog.FileName;
                }
            }
        }

        private void popFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    popFilePath = popFilePathInp.Text = openFileDialog.FileName;
                }
            }
        }

        private void mapFilePathInp_TextChanged(object sender, EventArgs e)
        {
            mapFilePath = mapFilePathInp.Text;
        }

        private void popFilePathInp_TextChanged(object sender, EventArgs e)
        {
            popFilePath = popFilePathInp.Text;
        }

        private void numericTimeSet_ValueChanged(object sender, EventArgs e)
        {
            if (autoCalcCheck.Checked)
                btnCalc_Click(sender, e);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(mapFilePath) || string.IsNullOrEmpty(popFilePath))
                    throw new System.InvalidOperationException("Map and population path can't be empty.");
                Graph g = FileReader.readGraphFromFile(mapFilePath, popFilePath);
                g.setInputTime((int) numericTimeSet.Value);
                g.BFS(g.getViralSource());
                Microsoft.Msagl.Drawing.Graph gDraw = GraphConverter.graphConverter(g);
                gViewer.Graph = gDraw;

                // Count total population and infected population
                int totalPop = 0;
                int totalInfected = 0;
                foreach (var src in g.getPopulation())
                {
                    totalPop += src.Value;
                    totalInfected += Convert.ToInt32(Math.Floor(g.I(src.Key, g.t(src.Key))));
                }
                totalPopulationBox.Text = totalPop.ToString();
                populationBox.Text = totalInfected.ToString();

                int totalNodeInfected = 0;
                nodeBox.Text = "";
                foreach (var node in g.getTimeInfected())
                {
                    if (node.Value != int.MaxValue)
                    {
                        totalNodeInfected++;
                        int infectedInNode = Convert.ToInt32(Math.Floor(g.I(node.Key, g.t(node.Key))));
                        nodeBox.Text += String.Format("{0}, t = {1}, n = {2}\r\n", node.Key.PadRight(5), node.Value.ToString().PadRight(5), infectedInNode);
                    }
                }
                totalNodeBox.Text = totalNodeInfected.ToString();
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message, "File input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("There is error in graph calculation", "Graph calculation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
