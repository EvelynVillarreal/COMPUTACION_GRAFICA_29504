using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmKite : Form
    {
        private readonly KiteController _controller = new KiteController();
        private Kite _model;
        private bool _drawing = false;

        public FrmKite()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateKite(txtDiagonal1.Text, txtDiagonal2.Text, out Kite kite, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = kite;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlKite.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiagonal1.Clear();
            txtDiagonal2.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlKite.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlKite_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlKite.BackColor);

            int centerX = pnlKite.Width / 2;
            int centerY = pnlKite.Height / 2;

            double scale = 15;
            int d1 = (int)(_model.Diagonal1 * scale);
            int d2 = (int)(_model.Diagonal2 * scale);

            PointF[] points = new PointF[] {
                new PointF(centerX, centerY - d1 / 2),
                new PointF(centerX + d2 / 2, centerY),
                new PointF(centerX, centerY + d1 / 2),
                new PointF(centerX - d2 / 2, centerY)
            };

            g.DrawPolygon(Pens.Orange, points);
            g.FillPolygon(Brushes.Orange, points);
        }
    }
}