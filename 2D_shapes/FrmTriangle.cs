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
    public partial class FrmTriangle : Form
    {
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;
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

            sideA = 0;
            sideB = 0;
            sideC = 0;

            txtPerimeter.Clear();
            txtArea.Clear();
            //txtType.Clear();
            txtType.Text = string.Empty;

            pnlTriangle.Invalidate(); //limpiar el panel de dibujo
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!double.TryParse(txtSideA.Text, out a) || !double.TryParse(txtSideB.Text, out b) || !double.TryParse(txtSideC.Text, out c))
            {
                MessageBox.Show("Please enter valid numeric values for the sides of the triangle.");
                return;
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                MessageBox.Show("Sides of the triangle must be positive numbers.");
                return;
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("The sum of any two sides must be greater than the third side.");
                return;
            }

            double perimeter = a + b + c;
            double s = perimeter / 2; // semiperímetro
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // fórmula de Herón

            //tipo de triángulo
            string triangleType;

            double[] lados = new double[] { a, b, c };
            Array.Sort(lados);
            double l1 = lados[0];
            double l2 = lados[1];
            double l3 = lados[2];
            double epsilon = 0.0001; // tolerancia para comparación de flotantes
            bool isRightAngled = Math.Abs(Math.Pow(l3, 2) - (Math.Pow(l1, 2) + Math.Pow(l2, 2))) < epsilon;

            if (isRightAngled)
            {
                triangleType = "Right-angled";
            }
            else if (a == b && b == c)
            {
                triangleType = "Equilateral";
            }
            
            else if (a == b || b == c || a == c)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            txtPerimeter.Text = perimeter.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
            txtType.Text = triangleType;

            sideA = a;
            sideB = b;
            sideC = c;

            pnlTriangle.Invalidate(); //refrescar el panel para que se vuelva a dibujar el triángulo con las nuevas dimensiones
        }

        private void pnlTriangle_Paint(object sender, PaintEventArgs e)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return; // no dibujar si no se han ingresado lados válidos
            }
            Graphics g = e.Graphics;
            double scale = 20;

            float x1 = 50;
            float y1 = pnlTriangle.Height - 50;

            float x2 = x1 + (float)(sideC * scale);
            float y2 = y1;

            double cosA = (Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / (2 * sideB * sideC);
            double angleA = Math.Acos(cosA);

            float x3 = x1 + (float)(sideB * scale * Math.Cos(angleA));
            float y3 = y1 - (float)(sideB * scale * Math.Sin(angleA));

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
