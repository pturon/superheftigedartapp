using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superheftigedartapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            button2.Width = 450;
            button2.Height = 450;
            GraphicsPath p = new GraphicsPath();
            PointF[] points = { new PointF(30, 100), new PointF(230, 90), new PointF(430, 100), new PointF(350, 420), new PointF(230, 410), new PointF(110, 420) };
            p.AddCurve(new PointF[] { points[0], points[1], points[2] });
            p.AddLine(points[2], points[3]);
            p.AddCurve(new PointF[] { points[3], points[4], points[5] });
            p.AddLine(points[5], points[0]);
            button2.Region = new Region(p);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            triple5.Width = 450;
            triple5.Height = 550;
            GraphicsPath p = new GraphicsPath();
            PointF[] points = { new PointF(110, 420), new PointF(230, 410), new PointF(350, 420), new PointF(330, 500), new PointF(230, 490), new PointF(130, 500) };
            p.AddCurve(new PointF[] { points[0], points[1], points[2] });
            p.AddLine(points[2], points[3]);
            p.AddCurve(new PointF[] { points[3], points[4], points[5] });
            p.AddLine(points[5], points[0]);
            triple5.Region = new Region(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button> {   double20, singleUpper20, triple20, singleLower20,
                                                        double5, singleUpper5, triple5, singleLower5,
                                                        double12, singleUpper12, triple12, singleLower12,
                                                        double9, singleUpper9, triple9, singleLower9,
                                                        double14, singleUpper14, triple14, singleLower14,
                                                        double11, singleUpper11, triple11, singleLower11,
                                                        double8, singleUpper8, triple8, singleLower8,
                                                        double16, singleUpper16, triple16, singleLower16,
                                                        double7, singleUpper7, triple7, singleLower7,
                                                        double19, singleUpper19, triple19, singleLower19,
                                                        double3, singleUpper3, triple3, singleLower3,
                                                        double17, singleUpper17, triple17, singleLower17,
                                                        double2, singleUpper2, triple2, singleLower2,
                                                        double15, singleUpper15, triple15, singleLower15,
                                                        double10, singleUpper10, triple10, singleLower10,
                                                        double6, singleUpper6, triple6, singleLower6,
                                                        double13, singleUpper13, triple13, singleLower13,
                                                        double4, singleUpper4, triple4, singleLower4,
                                                        double18, singleUpper18, triple18, singleLower18,
                                                        double1, singleUpper1, triple1, singleLower1

            };
            foreach(Button b in buttons)
            {
                List<string> values = new List<string>( b.Text.Split(';'));
                int height = 500;
                b.Width = 1700;
                b.Height = 1700;
                List<double> valuesAsDouble = new List<double>();
                foreach(string value in values)
                {
                    valuesAsDouble.Add(valuesAsDouble.Count < 3 ? double.Parse(value, CultureInfo.InvariantCulture.NumberFormat) / 180 * Math.PI : double.Parse(value, CultureInfo.InvariantCulture.NumberFormat));
                }
                GraphicsPath p = new GraphicsPath();
                PointF[] points = new PointF[] { new PointF((float) (Math.Cos(valuesAsDouble[0]) * height * valuesAsDouble[3]) + height, height - (float) (Math.Sin(valuesAsDouble[0]) * height * valuesAsDouble[3]) + 5),
                                             new PointF((float) (Math.Cos(valuesAsDouble[1]) * height * valuesAsDouble[3]) + height, height - (float) (Math.Sin(valuesAsDouble[1]) * height * valuesAsDouble[3]) + 5),
                                             new PointF((float) (Math.Cos(valuesAsDouble[2]) * height * valuesAsDouble[3]) + height, height - (float) (Math.Sin(valuesAsDouble[2]) * height * valuesAsDouble[3]) + 5),
                                             new PointF((float) (Math.Cos(valuesAsDouble[2]) * height * valuesAsDouble[4]) + height, height - (float) (Math.Sin(valuesAsDouble[2]) * height * valuesAsDouble[4]) + 5),
                                             new PointF((float) (Math.Cos(valuesAsDouble[1]) * height * valuesAsDouble[4]) + height ,height -  (float) (Math.Sin(valuesAsDouble[1]) * height * valuesAsDouble[4]) + 5),
                                             new PointF((float) (Math.Cos(valuesAsDouble[0]) * height * valuesAsDouble[4]) + height,height -  (float) (Math.Sin(valuesAsDouble[0]) * height * valuesAsDouble[4]) + 5),
                                                };
                p.AddCurve(new PointF[] { points[0], points[1], points[2] });
                p.AddLine(points[2], points[3]);
                p.AddCurve(new PointF[] { points[3], points[4], points[5] });
                p.AddLine(points[5], points[0]);
                b.Region = new Region(p);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tripple9_Click(object sender, EventArgs e)
        {

        }
    }
}
