using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmOctagon : Form
    {
        private readonly OctagonController _controller = new OctagonController();
        private Octagon _model;
        private bool _drawing = false;

        public FrmOctagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateOctagon(txtSide.Text, out Octagon octagon, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = octagon;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlOctagon.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlOctagon.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlOctagon_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlOctagon.BackColor);

            int centerX = pnlOctagon.Width / 2;
            int centerY = pnlOctagon.Height / 2;

            double scale = 15;
            int side = (int)(_model.Side * scale);
            int r = (int)(side / (2 * Math.Sin(Math.PI / 8)));

            PointF[] points = new PointF[8];
            for (int i = 0; i < 8; i++)
            {
                double angle = 2 * Math.PI * i / 8 - Math.PI / 8;
                points[i] = new PointF(
                    centerX + (float)(r * Math.Cos(angle)),
                    centerY + (float)(r * Math.Sin(angle))
                );
            }

            g.DrawPolygon(Pens.Teal, points);
            g.FillPolygon(Brushes.Teal, points);
        }
    }
}