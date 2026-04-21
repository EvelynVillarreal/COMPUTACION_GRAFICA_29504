namespace _2D_shapes
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miGraphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHexagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGraphicsToolStripMenuItem,
            this.miShapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miGraphicsToolStripMenuItem
            // 
            this.miGraphicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExampleToolStripMenuItem});
            this.miGraphicsToolStripMenuItem.Name = "miGraphicsToolStripMenuItem";
            this.miGraphicsToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.miGraphicsToolStripMenuItem.Text = "Graphics";
            // 
            // miExampleToolStripMenuItem
            // 
            this.miExampleToolStripMenuItem.Name = "miExampleToolStripMenuItem";
            this.miExampleToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.miExampleToolStripMenuItem.Text = "Example";
            this.miExampleToolStripMenuItem.Click += new System.EventHandler(this.miExampleToolStripMenuItem_Click);
            // 
            // miShapesToolStripMenuItem
            // 
            this.miShapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRectangleToolStripMenuItem,
            this.miTriangleToolStripMenuItem,
            this.miHexagonToolStripMenuItem});
            this.miShapesToolStripMenuItem.Name = "miShapesToolStripMenuItem";
            this.miShapesToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.miShapesToolStripMenuItem.Text = "Shapes";
            // 
            // miRectangleToolStripMenuItem
            // 
            this.miRectangleToolStripMenuItem.Name = "miRectangleToolStripMenuItem";
            this.miRectangleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.miRectangleToolStripMenuItem.Text = "Rectangle";
            this.miRectangleToolStripMenuItem.Click += new System.EventHandler(this.miRectangleToolStripMenuItem_Click);
            // 
            // miTriangleToolStripMenuItem
            // 
            this.miTriangleToolStripMenuItem.Name = "miTriangleToolStripMenuItem";
            this.miTriangleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.miTriangleToolStripMenuItem.Text = "Triangle";
            this.miTriangleToolStripMenuItem.Click += new System.EventHandler(this.miTriangleToolStripMenuItem_Click);
            // 
            // miHexagonToolStripMenuItem
            // 
            this.miHexagonToolStripMenuItem.Name = "miHexagonToolStripMenuItem";
            this.miHexagonToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.miHexagonToolStripMenuItem.Text = "Hexagon";
            this.miHexagonToolStripMenuItem.Click += new System.EventHandler(this.miHexagonToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miGraphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHexagonToolStripMenuItem;
    }
}