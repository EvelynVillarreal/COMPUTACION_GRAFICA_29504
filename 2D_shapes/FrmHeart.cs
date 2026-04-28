using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmHeart : Form
    {
        private readonly HeartController _controller = new HeartController();
        private Heart _model;
        private bool _drawing = false;

        public FrmHeart()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateHeart(txtWidth.Text, out Heart heart, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = heart;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlHeart.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWidth.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlHeart.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlHeart_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlHeart.BackColor);

            int centerX = pnlHeart.Width / 2;
            int centerY = pnlHeart.Height / 2;

            double scale = 15;
            int width = (int)(_model.Width * scale);
            int height = (int)(_model.Width * scale);

            int leftX = centerX - width / 2;
            int topY = centerY - height / 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                int w = width;
                int h = height;
                int x = centerX - w / 2;
                int y = centerY - h / 2;

                path.AddArc(x, y, w / 2, h / 2, 180, 90);
                path.AddArc(x + w / 2, y, w / 2, h / 2, 270, 90);

                PointF[] curvePoints = new PointF[] {
                    new PointF(centerX + w * 0.15f, centerY + h * 0.35f),
                    new PointF(centerX, centerY + h * 0.7f),
                    new PointF(centerX - w * 0.15f, centerY + h * 0.35f)
                };
                path.AddCurve(curvePoints);

                g.DrawPath(Pens.Red, path);
                g.FillPath(Brushes.Red, path);
            }
        }
    }
}