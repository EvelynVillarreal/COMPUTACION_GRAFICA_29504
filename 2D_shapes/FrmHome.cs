using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_shapes
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void miExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExample frmExample = new FrmExample();
            frmExample.MdiParent = this;
            frmExample.Show();
        }

        private void miRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle frmRectangle = new FrmRectangle();
            frmRectangle.MdiParent = this;
            frmRectangle.Show();
        }

        private void miTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangle = new FrmTriangle();
            frmTriangle.MdiParent = this;
            frmTriangle.Show();
        }

        private void miHexagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagon frmHexagon = new FrmHexagon();
            frmHexagon.MdiParent = this;
            frmHexagon.Show();
        }

        private void miCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circle frmCircle = new Circle();
            frmCircle.MdiParent = this;
            frmCircle.Show();
        }

        private void miEllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEllipse frmEllipse = new FrmEllipse();
            frmEllipse.MdiParent = this;
            frmEllipse.Show();
        }

        private void miSemicircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemicircle frmSemicircle = new FrmSemicircle();
            frmSemicircle.MdiParent = this;
            frmSemicircle.Show();
        }
    }
}
