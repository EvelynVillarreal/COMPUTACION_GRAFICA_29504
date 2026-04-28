using System;
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

        private void miStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStar frmStar = new FrmStar();
            frmStar.MdiParent = this;
            frmStar.Show();
        }

        private void miHeartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeart frmHeart = new FrmHeart();
            frmHeart.MdiParent = this;
            frmHeart.Show();
        }

        private void miPentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagon frmPentagon = new FrmPentagon();
            frmPentagon.MdiParent = this;
            frmPentagon.Show();
        }

        private void miOctagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagon frmOctagon = new FrmOctagon();
            frmOctagon.MdiParent = this;
            frmOctagon.Show();
        }

        private void miTrefoilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrefoil frmTrefoil = new FrmTrefoil();
            frmTrefoil.MdiParent = this;
            frmTrefoil.Show();
        }

        private void miKiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKite frmKite = new FrmKite();
            frmKite.MdiParent = this;
            frmKite.Show();
        }

        private void miTrapezoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoid frmTrapezoid = new FrmTrapezoid();
            frmTrapezoid.MdiParent = this;
            frmTrapezoid.Show();
        }

        private void miParallelogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParallelogram frmParallelogram = new FrmParallelogram();
            frmParallelogram.MdiParent = this;
            frmParallelogram.Show();
        }

        private void miCrescentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrescent frmCrescent = new FrmCrescent();
            frmCrescent.MdiParent = this;
            frmCrescent.Show();
        }

        private void miCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCross frmCross = new FrmCross();
            frmCross.MdiParent = this;
            frmCross.Show();
        }

        private void miQuarterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuarter frmQuarter = new FrmQuarter();
            frmQuarter.MdiParent = this;
            frmQuarter.Show();
        }

        private void miRhombusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhombus frmRhombus = new FrmRhombus();
            frmRhombus.MdiParent = this;
            frmRhombus.Show();
        }

        private void miTrefoilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmTrefoil frmTrefoil = new FrmTrefoil();
            frmTrefoil.MdiParent = this;
            frmTrefoil.Show();
        }
    }
}