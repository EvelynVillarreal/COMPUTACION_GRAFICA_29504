using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmQuarter : Form
    {
        private readonly QuarterCircleController _controller = new QuarterCircleController();
        private QuarterCircle _model;
        private bool _drawing = false;

        public FrmQuarter() { InitializeComponent(); }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateQuarterCircle(txtRadius.Text, out QuarterCircle quarterCircle, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _model = quarterCircle;
            _drawing = true;
            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");
            pnlQuarter.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadius.Clear(); txtPerimeter.Clear(); txtArea.Clear();
            _model = null; _drawing = false; pnlQuarter.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void pnlQuarter_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;
            Graphics g = e.Graphics; g.Clear(pnlQuarter.BackColor);
            int centerX = pnlQuarter.Width / 2; int centerY = pnlQuarter.Height / 2;
            double scale = 15;
            int r = (int)(_model.Radius * scale);
            g.DrawArc(Pens.Maroon, centerX, centerY, r, r, 180, 90);
            g.DrawLine(Pens.Maroon, centerX, centerY, centerX, centerY + r);
            g.DrawLine(Pens.Maroon, centerX, centerY, centerX + r, centerY);
            g.FillPie(Brushes.Maroon, centerX, centerY, r, r, 180, 90);
        }
    }
}