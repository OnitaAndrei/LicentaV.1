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
        int[,] whiteFace =
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
        };
        int[,] yellowFace =
        {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };
        int[,] blueFace =
        {
            { 2, 2, 2 },
            { 2, 2, 2 },
            { 2, 2, 2 }
        };
        int[,] greenFace =
        {
            { 3, 3, 3 },
            { 3, 3, 3 },
            { 3, 3, 3 }
        };
        int[,] redFace =
        {
            { 4, 4, 4 },
            { 4, 4, 4 },
            { 4, 4, 4 }
        };
        int[,] orangeFace =
        {
            { 5, 5, 5 },
            { 5, 5, 5 },
            { 5, 5, 5 }
        };
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
        int size = 100;
        private void Form1_Load(object sender, EventArgs ea)
        {
            for (int i = 0; i < 3; i++) {             
                a[i] *= size;
                b[i] *= size;
                c[i] *= size;
                d[i] *= size;
                e[i] *= size;
                f[i] *= size;
                g[i] *= size;
                h[i] *= size;                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs ea)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            float[] ap = rotate(a);
            float[] bp = rotate(b);
            float[] cp = rotate(c);
            float[] dp = rotate(d);
            float[] ep = rotate(e);
            float[] fp = rotate(f);
            float[] gp = rotate(g);
            float[] hp = rotate(h);
            for (int i = 0; i < 3; i++)
            {
                ap[i] += pictureBox1.Width/2;
                bp[i] += pictureBox1.Width/2;
                cp[i] += pictureBox1.Width/2;
                dp[i] += pictureBox1.Width/2;
                ep[i] += pictureBox1.Width/2;
                fp[i] += pictureBox1.Width/2;
                gp[i] += pictureBox1.Width/2;
                hp[i] += pictureBox1.Width/2;
            }
            PointF[] yellow = {
                 new PointF(ap[0], ap[1]),
                new PointF(dp[0], dp[1]),
                new PointF(hp[0], hp[1]),
                new PointF(ep[0], ep[1]),
            };
            PointF[] orange = {
                new PointF (ep[0], ep[1]),
                new PointF(fp[0], fp[1]),
                new PointF(gp[0], gp[1]),
                new PointF(hp[0], hp[1]),
            };

            PointF[] blue = {
                new PointF (ap[0], ap[1]),
                new PointF(bp[0], bp[1]),
                new PointF(fp[0], fp[1]),
                new PointF (ep[0], ep[1]),
            };

            PointF[] red = {
                new PointF (ap[0], ap[1]),
                new PointF(bp[0], bp[1]),
                new PointF(cp[0], cp[1]),
                new PointF(dp[0], dp[1]),
            };
            PointF[] green = {
                new PointF(cp[0], cp[1]),
                new PointF(dp[0], dp[1]),
                new PointF(hp[0], hp[1]),
                new PointF(gp[0], gp[1]),
            };

            PointF[] white = {
                 new PointF(bp[0], bp[1]),
                new PointF(cp[0], cp[1]),
                new PointF(gp[0], gp[1]),
                new PointF(fp[0], fp[1]),
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
                //grp.FillPolygon(new SolidBrush(sideColor.color), sideColor.points);
                grp.FillPolygon(new SolidBrush(Color.Black), sideColor.points);
            }
            pictureBox1.Image = img;
        }
    }
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
}
