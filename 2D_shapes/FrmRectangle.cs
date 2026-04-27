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
    public partial class FrmRectangle : Form
    {
        private readonly RectangleController _controller = new RectangleController();
        private RectangleShape _model;

        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //vaciar los campos
            txtWidthA.Clear();
            txtLengthB.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            _model = null;
            pnlRectangle.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!_controller.TryCreateRectangle(txtWidthA.Text, txtLengthB.Text, out RectangleShape rect, out string error))
            {
                MessageBox.Show(error, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _model = rect;

            txtPerimeter.Text = _model.Perimeter.ToString("0.00");
            txtArea.Text = _model.Area.ToString("0.00");

            pnlRectangle.Invalidate(); //refrescar el panel para que se vuelva a dibujar el rectangulo con las nuevas dimensiones
        }

        private void pnlRectangle_Paint(object sender, PaintEventArgs e)
        {
            if (_model == null) return;
            Graphics g = e.Graphics;
            int margin = 10;
            int pnlWidth = pnlRectangle.Width - 2 * margin;
            int pnlLength = pnlRectangle.Height - 2 * margin;

            double width = _model.Width;
            double length = _model.Length;

            double scale = 10;
            int rectWidth = (int)(width * scale);
            int rectLength = (int)(length * scale);

            int x = (pnlRectangle.Width - rectWidth) / 2;
            int y = (pnlRectangle.Height - rectLength) / 2;

            using (Pen pen = new Pen(Color.Blue, 2))
            {
                g.DrawRectangle(pen, x, y, rectWidth, rectLength);
            }
            g.FillRectangle(Brushes.Yellow, x, y, rectWidth, rectLength);
        }
    }
}
