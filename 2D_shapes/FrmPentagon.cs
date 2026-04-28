using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmPentagon : Form
    {
        private readonly PentagonController _controller = new PentagonController();
        private Pentagon _model;
        private bool _drawing = false;

        public FrmPentagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreatePentagon(txtSide.Text, out Pentagon pentagon, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = pentagon;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlPentagon.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlPentagon.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlPentagon_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlPentagon.BackColor);

            int centerX = pnlPentagon.Width / 2;
            int centerY = pnlPentagon.Height / 2;

            double scale = 15;
            int side = (int)(_model.Side * scale);
            int r = (int)(side / (2 * Math.Sin(Math.PI / 5)));

            PointF[] points = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = 2 * Math.PI * i / 5 - Math.PI / 2;
                points[i] = new PointF(
                    centerX + (float)(r * Math.Cos(angle)),
                    centerY + (float)(r * Math.Sin(angle))
                );
            }

            g.DrawPolygon(Pens.MediumPurple, points);
            g.FillPolygon(Brushes.MediumPurple, points);
        }
    }
}