using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmStar : Form
    {
        private readonly StarController _controller = new StarController();
        private Star _model;
        private bool _drawing = false;

        public FrmStar()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int points = 5;
            if (!string.IsNullOrWhiteSpace(txtPoints.Text))
            {
                int.TryParse(txtPoints.Text, out points);
            }

            if (!_controller.TryCreateStar(txtOuterRadius.Text, txtInnerRadius.Text, points, out Star star, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = star;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlStar.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOuterRadius.Clear();
            txtInnerRadius.Clear();
            txtPoints.Text = "5";
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlStar.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlStar_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlStar.BackColor);

            int centerX = pnlStar.Width / 2;
            int centerY = pnlStar.Height / 2;

            double scale = 15;
            int outerRadius = (int)(_model.OuterRadius * scale);
            int innerRadius = (int)(_model.InnerRadius * scale);

            PointF[] points = new PointF[_model.Points * 2];

            for (int i = 0; i < _model.Points * 2; i++)
            {
                double r = (i % 2 == 0) ? outerRadius : innerRadius;
                double angle = Math.PI * i / _model.Points - Math.PI / 2;
                points[i] = new PointF(
                    centerX + (float)(r * Math.Cos(angle)),
                    centerY + (float)(r * Math.Sin(angle))
                );
            }

            g.DrawPolygon(Pens.Gold, points);
            g.FillPolygon(Brushes.Gold, points);
        }
    }
}