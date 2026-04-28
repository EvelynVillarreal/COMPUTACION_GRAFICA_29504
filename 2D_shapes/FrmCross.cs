using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmCross : Form
    {
        private readonly CrossController _controller = new CrossController();
        private Cross _model;
        private bool _drawing = false;

        public FrmCross() { InitializeComponent(); }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateCross(txtWidth.Text, txtLength.Text, out Cross cross, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _model = cross;
            _drawing = true;
            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");
            pnlCross.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWidth.Clear(); txtLength.Clear(); txtPerimeter.Clear(); txtArea.Clear();
            _model = null; _drawing = false; pnlCross.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void pnlCross_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;
            Graphics g = e.Graphics; g.Clear(pnlCross.BackColor);
            int centerX = pnlCross.Width / 2; int centerY = pnlCross.Height / 2;
            double scale = 15;
            int w = (int)(_model.Width * scale);
            int l = (int)(_model.Length * scale);
            int arm = l / 3;
            g.FillRectangle(Brushes.Brown, centerX - w / 2, centerY - l / 2, w, l);
            g.FillRectangle(Brushes.Brown, centerX - l / 2, centerY - w / 2, l, w);
        }
    }
}