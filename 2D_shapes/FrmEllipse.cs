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
    public partial class FrmEllipse : Form
    {
        private readonly EllipseController _controller = new EllipseController();
        private Ellipse _model;

        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateEllipse(txtMajorAxis.Text, txtMinorAxis.Text, out Ellipse ellipse, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = ellipse;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlEllipse.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMajorAxis.Clear();
            txtMinorAxis.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;

            pnlEllipse.Invalidate(); //limpiar el panel de dibujo

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlEllipse_Paint(object sender, PaintEventArgs e)
        {
            if (_model == null) return;

            Graphics g = e.Graphics;
            g.Clear(pnlEllipse.BackColor);

            int centerX = pnlEllipse.Width / 2;
            int centerY = pnlEllipse.Height / 2;

            double scale = 20;

            int width = (int)(_model.MajorAxis * scale);
            int height = (int)(_model.MinorAxis * scale);

            int x = centerX - width / 2;
            int y = centerY - height / 2;

            using (Pen pen = new Pen(Color.Green, 2))
            {
                g.DrawEllipse(pen, x, y, width, height);
                g.FillEllipse(Brushes.LightGreen, x, y, width, height);
            }
        }
    }
}
