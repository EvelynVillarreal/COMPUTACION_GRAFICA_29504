using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmSemicircle : Form
    {
        // Controller and model are defined below in the same file to keep a minimal change set
        // while applying MVC/SOLID/OOP principles in this project.
        private readonly SemicircleController _controller = new SemicircleController();
        private Semicircle _model;
        private bool _drawing = false;

        public FrmSemicircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateSemicircle(txtRadius.Text, out Semicircle semicircle, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = semicircle;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlSemicircle.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlSemicircle.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlSemicircle_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlSemicircle.BackColor);

            int centerX = pnlSemicircle.Width / 2;
            int centerY = pnlSemicircle.Height / 2;

            double scale = 20; // escala básica
            int diameter = (int)(2 * _model.Radius * scale);

            int x = centerX - diameter / 2;
            int y = centerY - diameter / 2;

            g.DrawArc(Pens.Navy, x, y, diameter, diameter, 180, 180);
            g.DrawLine(Pens.Navy, x, centerY, x + diameter, centerY);
            g.FillPie(Brushes.Navy, x, y, diameter, diameter, 180, 180);
        }
    }

    // Model and Controller are now in separate files under Models\ and Controllers\
}
