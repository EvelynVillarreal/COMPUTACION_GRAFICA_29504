using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_shapes
{
    public partial class FrmRectangle : Form
    {
        double currentWidth = 0;
        double currentLength = 0;

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
            pnlRectangle.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double width, length;
            //validar que los campos no esten vacios
            if (string.IsNullOrEmpty(txtWidthA.Text) || string.IsNullOrEmpty(txtLengthB.Text))
            {
                MessageBox.Show("Please enter values for width and length.");
                return;
            }
            if(!double.TryParse(txtWidthA.Text, out width) || !double.TryParse(txtLengthB.Text, out length))
            {
                MessageBox.Show("Please enter valid numeric values for width and length.");
                return;
            }
            if (width <= 0 || length <= 0)
            {
                MessageBox.Show("Width and length must be positive numbers.");
                return;
            }
            //calcular el perimetro y area del rectangulo
            double perimeter = 2 * (width + length);
            double area = width * length;

            txtPerimeter.Text = perimeter.ToString("0.00");
            txtArea.Text = area.ToString("0.00");

            //graficar el rectangulo
            currentWidth = width;
            currentLength = length;

            pnlRectangle.Invalidate(); //refrescar el panel para que se vuelva a dibujar el rectangulo con las nuevas dimensiones
        }

        private void pnlRectangle_Paint(object sender, PaintEventArgs e)
        {
            //si los campos de ancho y largo estan vacios, no graficar el rectangulo
            if (currentWidth <=0 && currentLength <=0) return;
            Graphics g = e.Graphics;
            int margin = 10;
            int pnlWidth = pnlRectangle.Width - 2 * margin;
            int pnlLength = pnlRectangle.Height - 2 * margin;

            double width = double.TryParse(txtWidthA.Text, out double w) ? w : 0;
            double length = double.TryParse(txtLengthB.Text, out double l) ? l : 0;

            //double scaleX = pnlWidth / width;
            //double scaleY = pnlLength / length;
            //double scale = Math.Min(scaleX, scaleY);
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
