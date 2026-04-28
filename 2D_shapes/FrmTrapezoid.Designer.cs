namespace _2D_shapes
{
    partial class FrmTrapezoid
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBase1 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.pnlTrapezoid = new System.Windows.Forms.Panel();
            this.lblInputs = new System.Windows.Forms.Label();
            this.lblBase1 = new System.Windows.Forms.Label();
            this.lblBase2 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblOutputs = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblGraphic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 34);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            this.txtBase1.Location = new System.Drawing.Point(150, 85);
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(100, 26);
            this.txtBase1.TabIndex = 3;
            // 
            this.txtBase2.Location = new System.Drawing.Point(150, 117);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 26);
            this.txtBase2.TabIndex = 4;
            // 
            this.txtHeight.Location = new System.Drawing.Point(150, 149);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 5;
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(150, 303);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(100, 26);
            this.txtPerimeter.TabIndex = 6;
            // 
            this.txtArea.Location = new System.Drawing.Point(150, 377);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 26);
            this.txtArea.TabIndex = 7;
            // 
            this.pnlTrapezoid.Location = new System.Drawing.Point(376, 53);
            this.pnlTrapezoid.Name = "pnlTrapezoid";
            this.pnlTrapezoid.Size = new System.Drawing.Size(425, 401);
            this.pnlTrapezoid.TabIndex = 8;
            this.pnlTrapezoid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTrapezoid_Paint);
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Location = new System.Drawing.Point(12, 23);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(54, 20);
            this.lblInputs.TabIndex = 9;
            this.lblInputs.Text = "Inputs";
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(33, 91);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(62, 20);
            this.lblBase1.TabIndex = 10;
            this.lblBase1.Text = "Base 1:";
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Location = new System.Drawing.Point(25, 123);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(62, 20);
            this.lblBase2.TabIndex = 11;
            this.lblBase2.Text = "Base 2:";
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(33, 155);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(63, 20);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height:";
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(12, 220);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(66, 20);
            this.lblProcess.TabIndex = 13;
            this.lblProcess.Text = "Process";
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.Location = new System.Drawing.Point(12, 255);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(66, 20);
            this.lblOutputs.TabIndex = 14;
            this.lblOutputs.Text = "Outputs";
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(50, 306);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(81, 20);
            this.lblPerimeter.TabIndex = 15;
            this.lblPerimeter.Text = "Perimeter:";
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(50, 380);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "Area:";
            // 
            this.lblGraphic.AutoSize = true;
            this.lblGraphic.Location = new System.Drawing.Point(401, 23);
            this.lblGraphic.Name = "lblGraphic";
            this.lblGraphic.Size = new System.Drawing.Size(65, 20);
            this.lblGraphic.TabIndex = 17;
            this.lblGraphic.Text = "Graphic";
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGraphic);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblOutputs);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase1);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.pnlTrapezoid);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FrmTrapezoid";
            this.Text = "Trapezoid";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBase1;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Panel pnlTrapezoid;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.Label lblBase1;
        private System.Windows.Forms.Label lblBase2;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblOutputs;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblGraphic;
    }
}