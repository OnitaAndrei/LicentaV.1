using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaV._1
{
    public class sideColor
    {
        public PointF[] points;
        public Color color;
        public sideColor(PointF[] Points, Color Color)
        {
            this.points = Points;
            this.color = Color;
        }
    }
    public partial class Form1 : Form
    {
        float[] a = { 1, 1, 1 };
        float[] b = { 1, -1, 1 };
        float[] c = { 1, -1, -1 };
        float[] d = { 1, 1, -1 };
        float[] e = { -1, 1, 1 };
        float[] f = { -1, -1, 1 };
        float[] g = { -1, -1, -1 };
        float[] h = { -1, 1, -1 };
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap img;
        public float[] rotateX(float[] array, int degreesR)
        {
            double degrees = degreesR * Math.PI / 180.0;
            float aux1 = array[1];
            float aux2 = array[2];
            float[] result = { 1, 2, 3 };
            result[0] = array[0];
            result[1] = array[1];
            result[2] = array[2];
            result[1] = (float)Math.Cos(degrees) * aux1 - (float)Math.Sin(degrees) * aux2;
            result[2] = (float)Math.Sin(degrees) * aux1 + (float)Math.Cos(degrees) * aux2;
            return result;
        }
        public float[] rotateZ(float[] array, int degreesR)
        {
            double degrees = degreesR * Math.PI / 180.0;
            float aux0 =array[0];
            float aux1=array[1];      
            float[] result= {1,2,3};
            result[0]=array[0];
            result[1]=array[1];
            result[2]=array[2];
            result[0] = (float)Math.Cos(degrees) * aux0 - (float)Math.Sin(degrees) * aux1;
            result[1] = (float)Math.Sin(degrees) * aux0 + (float)Math.Cos(degrees) * aux1;
            return result;
        }
        public float[] rotateY(float[] array, int degreesR)
        {
            double degrees = degreesR * Math.PI / 180.0;
            float aux0 = array[0];
            float aux2 = array[2];
            float[] result = { 1, 2, 3 };
            result[0] = array[0];
            result[1] = array[1];
            result[2] = array[2];
            result[0] = (float)Math.Cos(degrees) * aux0 + (float)Math.Sin(degrees) * aux2;
            result[2] = -(float)Math.Sin(degrees) * aux0 + (float)Math.Cos(degrees) * aux2;
            return result;
        }

        public float[] rotate(float[] array)
        {
            float[] result = { 1, 2, 3 };
            result[0] = array[0];
            result[1] = array[1];
            result[2] = array[2];
            result = rotateX(array, trackBarx.Value);
            result = rotateY(result,trackBary.Value);
            result = rotateZ(result, trackBarz.Value);
            xLabel.Text = Convert.ToString(trackBarx.Value);
            yLabel.Text = Convert.ToString(trackBary.Value);
            zLabel.Text = Convert.ToString(trackBarz.Value);

            return result;
        }

        private void Form1_Load(object sender, EventArgs ea)
        {
            
        }
        
        public void drawLine(float a1,float a2, float b1,float b2,Pen pen)
        {
            int size = 100;
            grp.DrawLine(pen, a1 * size + 200, a2 * size + 200, b1 * size + 200, b2 * size + 200);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs ea)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.Coral);
            float[] ap = rotate(a);
            float[] bp = rotate(b);
            float[] cp = rotate(c);
            float[] dp = rotate(d);
            float[] ep = rotate(e);
            float[] fp = rotate(f);
            float[] gp = rotate(g);
            float[] hp = rotate(h);

            PointF[] yellow = {
                 new PointF(ap[0]*100+200, ap[1]*100+200),
                new PointF(dp[0]*100+200, dp[1]*100+200),
                new PointF(hp[0]*100+200, hp[1]*100+200),
                new PointF(ep[0]*100+200, ep[1]*100+200),
            };
            PointF[] orange = {
                new PointF (ep[0]*100+200, ep[1]*100+200),
                new PointF(fp[0]*100+200, fp[1]*100+200),
                new PointF(gp[0]*100+200, gp[1]*100+200),
                new PointF(hp[0]*100+200, hp[1]*100+200),
            };

            PointF[] blue = {
                new PointF (ap[0]*100+200, ap[1]*100+200),
                new PointF(bp[0]*100+200, bp[1]*100+200),
                new PointF(fp[0]*100+200, fp[1]*100+200),
                new PointF (ep[0]*100+200, ep[1]*100+200),
            };

            PointF[] red = {
                new PointF (ap[0]*100+200, ap[1]*100+200),
                new PointF(bp[0]*100+200, bp[1]*100+200),
                new PointF(cp[0]*100+200, cp[1]*100+200),
                new PointF(dp[0]*100+200, dp[1]*100+200),
            };
            PointF[] green = {
                new PointF(cp[0]*100+200, cp[1]*100+200),
                new PointF(dp[0]*100+200, dp[1]*100+200),
                new PointF(hp[0]*100+200, hp[1]*100+200),
                new PointF(gp[0]*100+200, gp[1]*100+200),
            };

            PointF[] white = {
                 new PointF(bp[0]*100+200, bp[1]*100+200),
                new PointF(cp[0]*100+200, cp[1]*100+200),
                new PointF(gp[0]*100+200, gp[1]*100+200),
                new PointF(fp[0]*100+200, fp[1]*100+200),
            };

            sideColor Yellow = new sideColor(yellow, Color.Yellow);
            sideColor White = new sideColor(white, Color.White);
            sideColor Red = new sideColor(red, Color.Red);
            sideColor Orange = new sideColor(orange, Color.Orange);
            sideColor Blue = new sideColor(blue, Color.Blue);
            sideColor Green = new sideColor(green, Color.Green);
            sideColor[] sideColors = { Red, Red, Red, Red, Red, Red };
            float[][] pointsP = { ap, bp, cp, dp, ep, fp, gp, hp };
            pointsP = pointsP.OrderBy(entry => entry[2]).ToArray();
            if (ap[2] >= pointsP[7][2])
            {
                sideColors[0] = Green;
                sideColors[1] = Orange;
                sideColors[2] = White;
                sideColors[3] = Blue;
                sideColors[4] = Red;
                sideColors[5] = Yellow;
            }
            else if (bp[2] >= pointsP[7][2])
            {
                sideColors[0] = Green;
                sideColors[1] = Orange;
                sideColors[2] = Yellow;
                sideColors[3] = Blue;
                sideColors[4] = Red;
                sideColors[5] = White;
            }
            else if (cp[2] >= pointsP[7][2])
            {
                sideColors[0] = Blue;
                sideColors[1] = Orange;
                sideColors[2] = Yellow;
                sideColors[3] = Green;
                sideColors[4] = Red;
                sideColors[5] = White;
            }
            else if (dp[2] >= pointsP[7][2])
            {
                sideColors[0] = Blue;
                sideColors[1] = Orange;
                sideColors[2] = White;
                sideColors[3] = Green;
                sideColors[4] = Red;
                sideColors[5] = Yellow;
            }
            else if (ep[2] >= pointsP[7][2])
            {
                sideColors[0] = Green;
                sideColors[1] = Red;
                sideColors[2] = White;
                sideColors[3] = Blue;
                sideColors[4] = Orange;
                sideColors[5] = Yellow;
            }
            else if (fp[2] >= pointsP[7][2])
            {
                sideColors[0] = Green;
                sideColors[1] = Red;
                sideColors[2] = Yellow;
                sideColors[3] = Blue;
                sideColors[4] = Orange;
                sideColors[5] = White;
            }
            else if (gp[2] >= pointsP[7][2])
            {
                sideColors[0] = Yellow;
                sideColors[1] = Red;
                sideColors[2] = Blue;
                sideColors[3] = White;
                sideColors[4] = Orange;
                sideColors[5] = Green;
            }
            else if (hp[2] >= pointsP[7][2])
            {
                sideColors[0] = White;
                sideColors[1] = Red;
                sideColors[2] = Blue;
                sideColors[3] = Yellow;
                sideColors[4] = Orange;
                sideColors[5] = Green;
            }
            foreach (sideColor sideColor in sideColors)
            {
                grp.FillPolygon(new SolidBrush(sideColor.color), sideColor.points);
            }

            pictureBox1.Image = img;
        }
    }
}
