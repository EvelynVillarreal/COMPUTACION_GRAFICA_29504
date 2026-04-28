using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmTrapezoid : Form
    {
        private readonly TrapezoidController _controller = new TrapezoidController();
        private Trapezoid _model;
        private bool _drawing = false;

        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateTrapezoid(txtBase1.Text, txtBase2.Text, txtHeight.Text, out Trapezoid trapezoid, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = trapezoid;
            _drawing = true;
            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");
            pnlTrapezoid.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBase1.Clear();
            txtBase2.Clear();
            txtHeight.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlTrapezoid.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTrapezoid_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlTrapezoid.BackColor);

            int centerX = pnlTrapezoid.Width / 2;
            int centerY = pnlTrapezoid.Height / 2;
            double scale = 15;
            int b1 = (int)(_model.Base1 * scale);
            int b2 = (int)(_model.Base2 * scale);
            int h = (int)(_model.Height * scale);

            PointF[] points = new PointF[] {
                new PointF(centerX - b1 / 2, centerY - h / 2),
                new PointF(centerX + b1 / 2, centerY - h / 2),
                new PointF(centerX + b2 / 2, centerY + h / 2),
                new PointF(centerX - b2 / 2, centerY + h / 2)
            };

            g.DrawPolygon(Pens.Coral, points);
            g.FillPolygon(Brushes.Coral, points);
        }
    }
}