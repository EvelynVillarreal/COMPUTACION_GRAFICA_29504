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
    public partial class FrmTriangle : Form
    {
        private readonly TriangleController _controller = new TriangleController();
        private Triangle _model;

        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();

            _model = null;

            txtPerimeter.Clear();
            txtArea.Clear();
            txtType.Text = string.Empty;

            pnlTriangle.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateTriangle(txtSideA.Text, txtSideB.Text, txtSideC.Text, out Triangle triangle, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = triangle;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");
            txtType.Text = _model.TriangleType;

            pnlTriangle.Invalidate(); //refrescar el panel para que se vuelva a dibujar el triángulo con las nuevas dimensiones
        }

        private void pnlTriangle_Paint(object sender, PaintEventArgs e)
        {
            if (_model == null) return;
            Graphics g = e.Graphics;
            double scale = 20;

            float x1 = 50;
            float y1 = pnlTriangle.Height - 50;

            float x2 = x1 + (float)(_model.C * scale);
            float y2 = y1;

            double cosA = (Math.Pow(_model.B, 2) + Math.Pow(_model.C, 2) - Math.Pow(_model.A, 2)) / (2 * _model.B * _model.C);
            double angleA = Math.Acos(cosA);

            float x3 = x1 + (float)(_model.B * scale * Math.Cos(angleA));
            float y3 = y1 - (float)(_model.B * scale * Math.Sin(angleA));

            PointF p1 = new PointF(x1, y1);
            PointF p2 = new PointF(x2, y2);
            PointF p3 = new PointF(x3, y3);

            using (Pen pen = new Pen(Color.Purple, 2))
            {
                g.DrawPolygon(pen, new PointF[] { p1, p2, p3 });
            }
        }
    }
}
