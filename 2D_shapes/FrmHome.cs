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
    }
}
