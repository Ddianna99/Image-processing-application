namespace ComputerVision
{
    partial class MainForm
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
            this.panelSource = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonNeg = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.buttonFTJ = new System.Windows.Forms.Button();
            this.buttonOutlier = new System.Windows.Forms.Button();
            this.buttonMarkov = new System.Windows.Forms.Button();
            this.buttonKirsch = new System.Windows.Forms.Button();
            this.buttonWB = new System.Windows.Forms.Button();
            this.buttonThreshold = new System.Windows.Forms.Button();
            this.panelSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSource
            // 
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSource.Controls.Add(this.trackBar1);
            this.panelSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSource.Location = new System.Drawing.Point(16, 15);
            this.panelSource.Margin = new System.Windows.Forms.Padding(4);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(425, 294);
            this.panelSource.TabIndex = 0;
            this.panelSource.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSource_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(214, 289);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(102, 56);
            this.trackBar1.TabIndex = 0;
            // 
            // panelDestination
            // 
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDestination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDestination.Location = new System.Drawing.Point(464, 15);
            this.panelDestination.Margin = new System.Windows.Forms.Padding(4);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(425, 294);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(16, 540);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonGrayscale);
            this.panel1.Location = new System.Drawing.Point(464, 334);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 233);
            this.panel1.TabIndex = 3;
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Location = new System.Drawing.Point(9, 191);
            this.buttonGrayscale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(100, 28);
            this.buttonGrayscale.TabIndex = 13;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // buttonNeg
            // 
            this.buttonNeg.Location = new System.Drawing.Point(16, 316);
            this.buttonNeg.Name = "buttonNeg";
            this.buttonNeg.Size = new System.Drawing.Size(125, 30);
            this.buttonNeg.TabIndex = 4;
            this.buttonNeg.Text = "Neg";
            this.buttonNeg.UseVisualStyleBackColor = true;
            this.buttonNeg.Click += new System.EventHandler(this.buttonNeg_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(147, 306);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Minimum = -255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(172, 56);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(12, 352);
            this.trackBar3.Maximum = 120;
            this.trackBar3.Minimum = -120;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(151, 56);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // buttonFTJ
            // 
            this.buttonFTJ.Location = new System.Drawing.Point(169, 352);
            this.buttonFTJ.Name = "buttonFTJ";
            this.buttonFTJ.Size = new System.Drawing.Size(133, 23);
            this.buttonFTJ.TabIndex = 7;
            this.buttonFTJ.Text = "FTJ";
            this.buttonFTJ.UseVisualStyleBackColor = true;
            this.buttonFTJ.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOutlier
            // 
            this.buttonOutlier.Location = new System.Drawing.Point(169, 400);
            this.buttonOutlier.Name = "buttonOutlier";
            this.buttonOutlier.Size = new System.Drawing.Size(133, 29);
            this.buttonOutlier.TabIndex = 8;
            this.buttonOutlier.Text = "Outlier";
            this.buttonOutlier.UseVisualStyleBackColor = true;
            this.buttonOutlier.Click += new System.EventHandler(this.buttonOutlier_Click);
            // 
            // buttonMarkov
            // 
            this.buttonMarkov.Location = new System.Drawing.Point(32, 400);
            this.buttonMarkov.Name = "buttonMarkov";
            this.buttonMarkov.Size = new System.Drawing.Size(109, 30);
            this.buttonMarkov.TabIndex = 10;
            this.buttonMarkov.Text = "Markov";
            this.buttonMarkov.UseVisualStyleBackColor = true;
            this.buttonMarkov.Click += new System.EventHandler(this.buttonMarkov_Click);
            // 
            // buttonKirsch
            // 
            this.buttonKirsch.Location = new System.Drawing.Point(325, 316);
            this.buttonKirsch.Name = "buttonKirsch";
            this.buttonKirsch.Size = new System.Drawing.Size(116, 32);
            this.buttonKirsch.TabIndex = 11;
            this.buttonKirsch.Text = "Kirsch";
            this.buttonKirsch.UseVisualStyleBackColor = true;
            this.buttonKirsch.Click += new System.EventHandler(this.buttonKirsch_Click);
            // 
            // buttonWB
            // 
            this.buttonWB.Location = new System.Drawing.Point(330, 370);
            this.buttonWB.Name = "buttonWB";
            this.buttonWB.Size = new System.Drawing.Size(110, 30);
            this.buttonWB.TabIndex = 12;
            this.buttonWB.Text = "White/Black";
            this.buttonWB.UseVisualStyleBackColor = true;
            this.buttonWB.Click += new System.EventHandler(this.buttonWB_Click);
            // 
            // buttonThreshold
            // 
            this.buttonThreshold.Location = new System.Drawing.Point(325, 406);
            this.buttonThreshold.Name = "buttonThreshold";
            this.buttonThreshold.Size = new System.Drawing.Size(112, 29);
            this.buttonThreshold.TabIndex = 13;
            this.buttonThreshold.Text = "Thresholding";
            this.buttonThreshold.UseVisualStyleBackColor = true;
            this.buttonThreshold.Click += new System.EventHandler(this.buttonThreshold_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 582);
            this.Controls.Add(this.buttonThreshold);
            this.Controls.Add(this.buttonWB);
            this.Controls.Add(this.buttonKirsch);
            this.Controls.Add(this.buttonMarkov);
            this.Controls.Add(this.buttonOutlier);
            this.Controls.Add(this.buttonFTJ);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.buttonNeg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGrayscale;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonNeg;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button buttonFTJ;
        private System.Windows.Forms.Button buttonOutlier;
        private System.Windows.Forms.Button buttonMarkov;
        private System.Windows.Forms.Button buttonKirsch;
        private System.Windows.Forms.Button buttonWB;
        private System.Windows.Forms.Button buttonThreshold;
    }
}

