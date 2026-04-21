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
    public partial class FrmHexagon : Form
    {
        double lHexagon = 0;
        public FrmHexagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double l;
            if(!double.TryParse(txtL.Text, out l)||l<=0)
            {
                MessageBox.Show("Please enter a valid numeric value for the side of the hexagon.");
                return;
            }
            lHexagon = l;
            double a = l * 0.866; //altura del hexagono
            double perimeter = 6 * l;
            double area = (perimeter * a)/2;

            txtPerimeter.Text = perimeter.ToString("0.00");
            txtArea.Text = area.ToString("0.00");

            pnlHexagon.Invalidate(); //limpiar el panel de dibujo

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtL.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            pnlHexagon.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHexagon_Paint(object sender, PaintEventArgs e)
        {
            if(lHexagon <= 0) return;
            Graphics g = e.Graphics;

            int centerX = pnlHexagon.Width / 2;
            int centerY = pnlHexagon.Height / 2;

            double scale = 20; // escala para ajustar el tamaño del hexágono en el panel
            double r = lHexagon * scale; // radio del círculo circunscrito al hexágono

            PointF[] vertices = new PointF[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i; // 60 grados
                float x = centerX + (float)(r * Math.Cos(angle));
                float y = centerY - (float)(r * Math.Sin(angle));

                vertices[i] = new PointF(x, y);
            }
            Brush[] brushes = new Brush[]
            {
                Brushes.Red,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Cyan,
                Brushes.Blue,
                Brushes.Magenta
            };
            PointF center = new PointF(centerX, centerY);
            for (int i = 0; i < 6; i++)
            {
                PointF p1 = center;
                PointF p2 = vertices[i];
                PointF p3 = vertices[(i + 1) % 6];

                g.DrawPolygon(Pens.Black, new PointF[] { p1,p2,p3});
                g.FillPolygon(brushes[i], new PointF[] { p1, p2, p3});
      
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPolygon(pen, vertices);
            }
        }
    }
}
