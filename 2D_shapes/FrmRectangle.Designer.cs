namespace _2D_shapes
{
    partial class FrmRectangle
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
            this.lblInputs = new System.Windows.Forms.Label();
            this.lblWidthA = new System.Windows.Forms.Label();
            this.lblLengthB = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblOutputs = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblGraph = new System.Windows.Forms.Label();
            this.txtWidthA = new System.Windows.Forms.TextBox();
            this.txtLengthB = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlRectangle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Location = new System.Drawing.Point(12, 9);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(54, 20);
            this.lblInputs.TabIndex = 0;
            this.lblInputs.Text = "Inputs";
            // 
            // lblWidthA
            // 
            this.lblWidthA.AutoSize = true;
            this.lblWidthA.Location = new System.Drawing.Point(33, 45);
            this.lblWidthA.Name = "lblWidthA";
            this.lblWidthA.Size = new System.Drawing.Size(77, 20);
            this.lblWidthA.TabIndex = 1;
            this.lblWidthA.Text = "Width (a):";
            // 
            // lblLengthB
            // 
            this.lblLengthB.AutoSize = true;
            this.lblLengthB.Location = new System.Drawing.Point(33, 104);
            this.lblLengthB.Name = "lblLengthB";
            this.lblLengthB.Size = new System.Drawing.Size(86, 20);
            this.lblLengthB.TabIndex = 2;
            this.lblLengthB.Text = "Length (b):";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(12, 163);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(66, 20);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Text = "Process";
            // 
            // lblOutputs
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.Location = new System.Drawing.Point(12, 273);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(66, 20);
            this.lblOutputs.TabIndex = 4;
            this.lblOutputs.Text = "Outputs";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(33, 317);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(81, 20);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "Perimeter:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(33, 370);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area:";
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Location = new System.Drawing.Point(396, 9);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(54, 20);
            this.lblGraph.TabIndex = 7;
            this.lblGraph.Text = "Graph";
            // 
            // txtWidthA
            // 
            this.txtWidthA.Location = new System.Drawing.Point(146, 42);
            this.txtWidthA.Name = "txtWidthA";
            this.txtWidthA.Size = new System.Drawing.Size(100, 26);
            this.txtWidthA.TabIndex = 8;
            // 
            // txtLengthB
            // 
            this.txtLengthB.Location = new System.Drawing.Point(146, 101);
            this.txtLengthB.Name = "txtLengthB";
            this.txtLengthB.Size = new System.Drawing.Size(100, 26);
            this.txtLengthB.TabIndex = 9;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(146, 314);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(100, 26);
            this.txtPerimeter.TabIndex = 10;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(146, 367);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 26);
            this.txtArea.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(37, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 29);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(146, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 29);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlRectangle
            // 
            this.pnlRectangle.Location = new System.Drawing.Point(374, 45);
            this.pnlRectangle.Name = "pnlRectangle";
            this.pnlRectangle.Size = new System.Drawing.Size(414, 330);
            this.pnlRectangle.TabIndex = 15;
            this.pnlRectangle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRectangle_Paint);
            // 
            // FrmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRectangle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtLengthB);
            this.Controls.Add(this.txtWidthA);
            this.Controls.Add(this.lblGraph);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblOutputs);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblLengthB);
            this.Controls.Add(this.lblWidthA);
            this.Controls.Add(this.lblInputs);
            this.Name = "FrmRectangle";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.Label lblWidthA;
        private System.Windows.Forms.Label lblLengthB;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblOutputs;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.TextBox txtWidthA;
        private System.Windows.Forms.TextBox txtLengthB;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlRectangle;
    }
}