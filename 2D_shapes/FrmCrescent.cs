using System;
using System.Drawing;
using System.Windows.Forms;
using _2D_shapes.Controllers;
using _2D_shapes.Models;

namespace _2D_shapes
{
    public partial class FrmCrescent : Form
    {
        private readonly CrescentController _controller = new CrescentController();
        private Crescent _model;
        private bool _drawing = false;

        public FrmCrescent() { InitializeComponent(); }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateCrescent(txtOuterRadius.Text, txtInnerRadius.Text, out Crescent crescent, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _model = crescent;
            _drawing = true;
            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");
            pnlCrescent.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOuterRadius.Clear(); txtInnerRadius.Clear(); txtPerimeter.Clear(); txtArea.Clear();
            _model = null; _drawing = false; pnlCrescent.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void pnlCrescent_Paint(object sender, PaintEventArgs e)
        {
            if (!_drawing || _model == null) return;
            Graphics g = e.Graphics; g.Clear(pnlCrescent.BackColor);
            int centerX = pnlCrescent.Width / 2; int centerY = pnlCrescent.Height / 2;
            double scale = 15;
            int or = (int)(_model.OuterRadius * scale);
            int ir = (int)(_model.InnerRadius * scale);
            // Activar suavizado (mejora visual)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Círculo grande (base)
            g.FillEllipse(Brushes.Gray, centerX - or, centerY - or, or * 2, or * 2);

            // Desplazamiento vertical (clave para "sonrisa")
            int offsetY = (int)(or * 0.5); // ajusta este valor

            // Círculo que recorta (arriba)
            g.FillEllipse(
                new SolidBrush(pnlCrescent.BackColor),
                centerX - ir,
                centerY - ir - offsetY,
                ir * 2,
                ir * 2
            );
        }
    }
}