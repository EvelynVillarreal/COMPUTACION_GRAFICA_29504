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
    public partial class FrmExample : Form
    {
        public FrmExample()
        {
            InitializeComponent();
        }

        private void FrmExample_Load(object sender, EventArgs e)
        {

        }

        private void FrmExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Blue, 2);

            g.DrawLine(pen, 20, 20, 200, 100);

            g.DrawRectangle(Pens.Red, 50, 50, 100, 60);

            g.DrawEllipse(Pens.Black, 200, 200, 150, 200);

            g.DrawString("Hola", new Font("Arial", 12), Brushes.Black, 100, 150);

            g.DrawRectangle(Pens.Red, 0, 0, 200, 200);
        }
    }
}
