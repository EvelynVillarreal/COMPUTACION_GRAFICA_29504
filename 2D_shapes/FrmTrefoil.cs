using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmTrefoil : Form
    {
        private readonly TrefoilController _controller = new TrefoilController();
        private Trefoil _model;
        private bool _drawing = false;

        public FrmTrefoil()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateTrefoil(txtRadius.Text, out Trefoil trefoil, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = trefoil;
            _drawing = true;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlTrefoil.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            _drawing = false;
            pnlTrefoil.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTrefoil_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlTrefoil.BackColor);

            int centerX = pnlTrefoil.Width / 2;
            int centerY = pnlTrefoil.Height / 2;

            double scale = 15;
            int r = (int)(_model.Radius * scale);

            g.FillEllipse(Brushes.Green, centerX - r / 2, centerY - r - r / 4, r, r);
            g.FillEllipse(Brushes.Green, centerX - r - r / 4, centerY - r / 4, r, r);
            g.FillEllipse(Brushes.Green, centerX + r / 4, centerY - r / 4, r, r);
        }
    }
}