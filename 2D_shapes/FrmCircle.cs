using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class Circle : Form
    {
        private readonly CircleController _controller = new CircleController();
        private CircleShape _model;
        private bool _drawing = false;

        public Circle()
        {
            InitializeComponent();
        }

        private void pnlCircle_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlCircle.BackColor);

            int centerX = pnlCircle.Width / 2;
            int centerY = pnlCircle.Height / 2;

            double scale = 20;
            int diameter = (int)(2 * _model.Radius * scale);
            int x = centerX - diameter / 2;
            int y = centerY - diameter / 2;

            g.DrawEllipse(Pens.Blue, x, y, diameter, diameter);
            g.FillEllipse(Brushes.LightBlue, x, y, diameter, diameter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateCircle(txtRadius.Text, out CircleShape circle, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = circle;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlCircle.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlCircle.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
