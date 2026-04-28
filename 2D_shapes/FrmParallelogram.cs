using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmParallelogram : Form
    {
        private readonly ParallelogramController _controller = new ParallelogramController();
        private Parallelogram _model;
        private bool _drawing = false;

        public FrmParallelogram()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateParallelogram(txtBase.Text, txtHeight.Text, out Parallelogram parallelogram, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = parallelogram;
            _drawing = true;
            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");
            pnlParallelogram.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtHeight.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlParallelogram.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlParallelogram_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlParallelogram.BackColor);

            int centerX = pnlParallelogram.Width / 2;
            int centerY = pnlParallelogram.Height / 2;
            double scale = 15;
            int b = (int)(_model.Base * scale);
            int h = (int)(_model.Height * scale);
            int skew = b / 4;

            PointF[] points = new PointF[] {
                new PointF(centerX - b / 2 + skew, centerY - h / 2),
                new PointF(centerX + b / 2 + skew, centerY - h / 2),
                new PointF(centerX + b / 2 - skew, centerY + h / 2),
                new PointF(centerX - b / 2 - skew, centerY + h / 2)
            };

            g.DrawPolygon(Pens.SlateBlue, points);
            g.FillPolygon(Brushes.SlateBlue, points);
        }
    }
}