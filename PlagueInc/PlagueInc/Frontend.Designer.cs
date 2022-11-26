namespace PlagueInc
{
    partial class Frontend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.numericTimeSet = new System.Windows.Forms.NumericUpDown();
            this.mapFileBtn = new System.Windows.Forms.Button();
            this.fileInput = new System.Windows.Forms.GroupBox();
            this.popFilePathInp = new System.Windows.Forms.TextBox();
            this.mapFilePathInp = new System.Windows.Forms.TextBox();
            this.popFileBtn = new System.Windows.Forms.Button();
            this.popFileLbl = new System.Windows.Forms.Label();
            this.mapFileLbl = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.graphOutput = new System.Windows.Forms.GroupBox();
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.inputTime = new System.Windows.Forms.GroupBox();
            this.autoCalcCheck = new System.Windows.Forms.CheckBox();
            this.autoCalcLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.calculateBFS = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nodeBox = new System.Windows.Forms.TextBox();
            this.infNodeListLbl = new System.Windows.Forms.Label();
            this.totalNodeBox = new System.Windows.Forms.TextBox();
            this.infNodeCountLbl = new System.Windows.Forms.Label();
            this.populationBox = new System.Windows.Forms.TextBox();
            this.infPopLbl = new System.Windows.Forms.Label();
            this.totalPopulationBox = new System.Windows.Forms.TextBox();
            this.totalPopLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeSet)).BeginInit();
            this.fileInput.SuspendLayout();
            this.graphOutput.SuspendLayout();
            this.inputTime.SuspendLayout();
            this.calculateBFS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericTimeSet
            // 
            this.numericTimeSet.Location = new System.Drawing.Point(80, 31);
            this.numericTimeSet.Margin = new System.Windows.Forms.Padding(4);
            this.numericTimeSet.Name = "numericTimeSet";
            this.numericTimeSet.Size = new System.Drawing.Size(120, 22);
            this.numericTimeSet.TabIndex = 2;
            this.numericTimeSet.ValueChanged += new System.EventHandler(this.numericTimeSet_ValueChanged);
            // 
            // mapFileBtn
            // 
            this.mapFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapFileBtn.Location = new System.Drawing.Point(691, 30);
            this.mapFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapFileBtn.Name = "mapFileBtn";
            this.mapFileBtn.Size = new System.Drawing.Size(29, 23);
            this.mapFileBtn.TabIndex = 4;
            this.mapFileBtn.Text = "...";
            this.mapFileBtn.UseVisualStyleBackColor = true;
            this.mapFileBtn.Click += new System.EventHandler(this.mapFileBtn_Click);
            // 
            // fileInput
            // 
            this.fileInput.Controls.Add(this.popFilePathInp);
            this.fileInput.Controls.Add(this.mapFilePathInp);
            this.fileInput.Controls.Add(this.popFileBtn);
            this.fileInput.Controls.Add(this.popFileLbl);
            this.fileInput.Controls.Add(this.mapFileLbl);
            this.fileInput.Controls.Add(this.mapFileBtn);
            this.fileInput.Location = new System.Drawing.Point(31, 688);
            this.fileInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileInput.Name = "fileInput";
            this.fileInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileInput.Size = new System.Drawing.Size(727, 111);
            this.fileInput.TabIndex = 6;
            this.fileInput.TabStop = false;
            this.fileInput.Text = "File Input";
            // 
            // popFilePathInp
            // 
            this.popFilePathInp.Location = new System.Drawing.Point(128, 71);
            this.popFilePathInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.popFilePathInp.Name = "popFilePathInp";
            this.popFilePathInp.Size = new System.Drawing.Size(556, 22);
            this.popFilePathInp.TabIndex = 11;
            this.popFilePathInp.TextChanged += new System.EventHandler(this.popFilePathInp_TextChanged);
            // 
            // mapFilePathInp
            // 
            this.mapFilePathInp.Location = new System.Drawing.Point(128, 30);
            this.mapFilePathInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapFilePathInp.Name = "mapFilePathInp";
            this.mapFilePathInp.Size = new System.Drawing.Size(556, 22);
            this.mapFilePathInp.TabIndex = 10;
            this.mapFilePathInp.TextChanged += new System.EventHandler(this.mapFilePathInp_TextChanged);
            // 
            // popFileBtn
            // 
            this.popFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popFileBtn.Location = new System.Drawing.Point(691, 71);
            this.popFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.popFileBtn.Name = "popFileBtn";
            this.popFileBtn.Size = new System.Drawing.Size(29, 23);
            this.popFileBtn.TabIndex = 9;
            this.popFileBtn.Text = "...";
            this.popFileBtn.UseVisualStyleBackColor = true;
            this.popFileBtn.Click += new System.EventHandler(this.popFileBtn_Click);
            // 
            // popFileLbl
            // 
            this.popFileLbl.AutoSize = true;
            this.popFileLbl.Location = new System.Drawing.Point(19, 75);
            this.popFileLbl.Name = "popFileLbl";
            this.popFileLbl.Size = new System.Drawing.Size(101, 17);
            this.popFileLbl.TabIndex = 6;
            this.popFileLbl.Text = "Population File";
            // 
            // mapFileLbl
            // 
            this.mapFileLbl.AutoSize = true;
            this.mapFileLbl.Location = new System.Drawing.Point(19, 33);
            this.mapFileLbl.Name = "mapFileLbl";
            this.mapFileLbl.Size = new System.Drawing.Size(61, 17);
            this.mapFileLbl.TabIndex = 5;
            this.mapFileLbl.Text = "Map File";
            this.mapFileLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // graphOutput
            // 
            this.graphOutput.Controls.Add(this.gViewer);
            this.graphOutput.Location = new System.Drawing.Point(31, 25);
            this.graphOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphOutput.Name = "graphOutput";
            this.graphOutput.Size = new System.Drawing.Size(874, 644);
            this.graphOutput.TabIndex = 7;
            this.graphOutput.TabStop = false;
            this.graphOutput.Text = "Graph Output";
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(21, 33);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(836, 583);
            this.gViewer.TabIndex = 0;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = planeTransformation1;
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // inputTime
            // 
            this.inputTime.Controls.Add(this.autoCalcCheck);
            this.inputTime.Controls.Add(this.autoCalcLbl);
            this.inputTime.Controls.Add(this.timeLbl);
            this.inputTime.Controls.Add(this.numericTimeSet);
            this.inputTime.Location = new System.Drawing.Point(764, 688);
            this.inputTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTime.Name = "inputTime";
            this.inputTime.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTime.Size = new System.Drawing.Size(207, 111);
            this.inputTime.TabIndex = 8;
            this.inputTime.TabStop = false;
            this.inputTime.Text = "Input Time";
            // 
            // autoCalcCheck
            // 
            this.autoCalcCheck.AutoSize = true;
            this.autoCalcCheck.Location = new System.Drawing.Point(80, 74);
            this.autoCalcCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoCalcCheck.Name = "autoCalcCheck";
            this.autoCalcCheck.Size = new System.Drawing.Size(18, 17);
            this.autoCalcCheck.TabIndex = 14;
            this.autoCalcCheck.UseVisualStyleBackColor = true;
            // 
            // autoCalcLbl
            // 
            this.autoCalcLbl.AutoSize = true;
            this.autoCalcLbl.Location = new System.Drawing.Point(5, 75);
            this.autoCalcLbl.Name = "autoCalcLbl";
            this.autoCalcLbl.Size = new System.Drawing.Size(68, 17);
            this.autoCalcLbl.TabIndex = 13;
            this.autoCalcLbl.Text = "Auto Calc";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(5, 33);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(39, 17);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "Time";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(7, 30);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(107, 64);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Kalkulasi";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // calculateBFS
            // 
            this.calculateBFS.Controls.Add(this.btnCalc);
            this.calculateBFS.Location = new System.Drawing.Point(977, 688);
            this.calculateBFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateBFS.Name = "calculateBFS";
            this.calculateBFS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateBFS.Size = new System.Drawing.Size(121, 111);
            this.calculateBFS.TabIndex = 13;
            this.calculateBFS.TabStop = false;
            this.calculateBFS.Text = "Calculate BFS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nodeBox);
            this.groupBox1.Controls.Add(this.infNodeListLbl);
            this.groupBox1.Controls.Add(this.totalNodeBox);
            this.groupBox1.Controls.Add(this.infNodeCountLbl);
            this.groupBox1.Controls.Add(this.populationBox);
            this.groupBox1.Controls.Add(this.infPopLbl);
            this.groupBox1.Controls.Add(this.totalPopulationBox);
            this.groupBox1.Controls.Add(this.totalPopLbl);
            this.groupBox1.Location = new System.Drawing.Point(911, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 644);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casualty Output";
            // 
            // nodeBox
            // 
            this.nodeBox.Location = new System.Drawing.Point(9, 221);
            this.nodeBox.Multiline = true;
            this.nodeBox.Name = "nodeBox";
            this.nodeBox.ReadOnly = true;
            this.nodeBox.Size = new System.Drawing.Size(192, 417);
            this.nodeBox.TabIndex = 20;
            // 
            // infNodeListLbl
            // 
            this.infNodeListLbl.AutoSize = true;
            this.infNodeListLbl.Location = new System.Drawing.Point(6, 200);
            this.infNodeListLbl.Name = "infNodeListLbl";
            this.infNodeListLbl.Size = new System.Drawing.Size(129, 17);
            this.infNodeListLbl.TabIndex = 19;
            this.infNodeListLbl.Text = "Infected Nodes List";
            // 
            // totalNodeBox
            // 
            this.totalNodeBox.Location = new System.Drawing.Point(9, 164);
            this.totalNodeBox.Name = "totalNodeBox";
            this.totalNodeBox.ReadOnly = true;
            this.totalNodeBox.Size = new System.Drawing.Size(192, 22);
            this.totalNodeBox.TabIndex = 18;
            // 
            // infNodeCountLbl
            // 
            this.infNodeCountLbl.AutoSize = true;
            this.infNodeCountLbl.Location = new System.Drawing.Point(6, 143);
            this.infNodeCountLbl.Name = "infNodeCountLbl";
            this.infNodeCountLbl.Size = new System.Drawing.Size(144, 17);
            this.infNodeCountLbl.TabIndex = 17;
            this.infNodeCountLbl.Text = "Infected Nodes Count";
            // 
            // populationBox
            // 
            this.populationBox.Location = new System.Drawing.Point(9, 105);
            this.populationBox.Name = "populationBox";
            this.populationBox.ReadOnly = true;
            this.populationBox.Size = new System.Drawing.Size(192, 22);
            this.populationBox.TabIndex = 16;
            // 
            // infPopLbl
            // 
            this.infPopLbl.AutoSize = true;
            this.infPopLbl.Location = new System.Drawing.Point(6, 84);
            this.infPopLbl.Name = "infPopLbl";
            this.infPopLbl.Size = new System.Drawing.Size(129, 17);
            this.infPopLbl.TabIndex = 15;
            this.infPopLbl.Text = "Infected Population";
            // 
            // totalPopulationBox
            // 
            this.totalPopulationBox.Location = new System.Drawing.Point(9, 47);
            this.totalPopulationBox.Name = "totalPopulationBox";
            this.totalPopulationBox.ReadOnly = true;
            this.totalPopulationBox.Size = new System.Drawing.Size(192, 22);
            this.totalPopulationBox.TabIndex = 14;
            // 
            // totalPopLbl
            // 
            this.totalPopLbl.AutoSize = true;
            this.totalPopLbl.Location = new System.Drawing.Point(6, 26);
            this.totalPopLbl.Name = "totalPopLbl";
            this.totalPopLbl.Size = new System.Drawing.Size(111, 17);
            this.totalPopLbl.TabIndex = 12;
            this.totalPopLbl.Text = "Total Population";
            // 
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 819);
            this.Controls.Add(this.calculateBFS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.graphOutput);
            this.Controls.Add(this.fileInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frontend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.T. Wabah";
            this.Load += new System.EventHandler(this.Frontend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeSet)).EndInit();
            this.fileInput.ResumeLayout(false);
            this.fileInput.PerformLayout();
            this.graphOutput.ResumeLayout(false);
            this.inputTime.ResumeLayout(false);
            this.inputTime.PerformLayout();
            this.calculateBFS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericTimeSet;
        private System.Windows.Forms.Button mapFileBtn;
        private System.Windows.Forms.GroupBox fileInput;
        private System.Windows.Forms.Label mapFileLbl;
        private System.Windows.Forms.Label popFileLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button popFileBtn;
        private System.Windows.Forms.TextBox popFilePathInp;
        private System.Windows.Forms.TextBox mapFilePathInp;
        private System.Windows.Forms.GroupBox graphOutput;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private System.Windows.Forms.GroupBox inputTime;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox calculateBFS;
        private System.Windows.Forms.Label autoCalcLbl;
        private System.Windows.Forms.CheckBox autoCalcCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nodeBox;
        private System.Windows.Forms.Label infNodeListLbl;
        private System.Windows.Forms.TextBox totalNodeBox;
        private System.Windows.Forms.Label infNodeCountLbl;
        private System.Windows.Forms.TextBox populationBox;
        private System.Windows.Forms.Label infPopLbl;
        private System.Windows.Forms.TextBox totalPopulationBox;
        private System.Windows.Forms.Label totalPopLbl;
    }
}

