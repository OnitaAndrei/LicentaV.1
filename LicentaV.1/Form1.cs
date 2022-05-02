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
        float[] a1 = { 1, 1, 1 };
        float[] b1 = { 1, -1, 1 };
        float[] c1 = { 1, -1, -1 };
        float[] d1 = { 1, 1, -1 };
        float[] e1 = { -1, 1, 1 };
        float[] f1 = { -1, -1, 1 };
        float[] g1 = { -1, -1, -1 };
        float[] h1 = { -1, 1, -1 };
        string[,] whiteFace =
        {
            { "Ac", "As", "Bc" },
            { "Ds", "0", "Bs" },
            { "Dc", "Cs", "Cc" }
        };
        string[,] orangeFace =
{
            { "Ec", "Es", "Fc" },
            { "Hc", "0", "Fs" },
            { "Hc", "Gs", "Gc" }
        };
        string[,] greenFace =
{
            { "Ic", "Is", "Jc" },
            { "Ls", "0", "Js" },
            { "Lc", "Ks",  "Kc"}
        };
        string[,] redFace =
        {
            { "Mc", "Ms", "Nc" },
            { "Ps", "0", "Ns" },
            { "Pc", "Os", "Oc" }
        };
        string[,] blueFace =
        {
            { "Qc", "Qs", "Rc" },
            { "Ts", "0", "Rs" },
            { "Tc", "Ss", "Sc" }
        };
        string[,] yellowFace =
{
            { "Uc", "Us", "Vc" },
            { "Xs", "0", "Vs" },
            { "Xc", "Ws", "Wc" }
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

        Cube cube1  = new Cube(55 , 55, 55);
        Cube cube2  = new Cube(100, 55, 55);
        Cube cube3  = new Cube(145, 55, 55);
        Cube cube4  = new Cube(55 , 55, 100);
        Cube cube5  = new Cube(100, 55, 100);
        Cube cube6  = new Cube(145, 55, 100);
        Cube cube7  = new Cube(55 , 55, 145);
        Cube cube8  = new Cube(100, 55, 145);
        Cube cube9  = new Cube(145, 55, 145);
        Cube cube10 = new Cube(55 , 100, 55);
        Cube cube11 = new Cube(100, 100, 55);
        Cube cube12 = new Cube(145, 100, 55);
        Cube cube13 = new Cube(55 , 100, 100);        
        Cube cube14 = new Cube(145, 100, 100);
        Cube cube15 = new Cube(55 , 100, 145);
        Cube cube16 = new Cube(100, 100, 145);
        Cube cube17 = new Cube(145, 100, 145);
        Cube cube18 = new Cube(55 , 145, 55);
        Cube cube19 = new Cube(100, 145, 55);
        Cube cube20 = new Cube(145, 145, 55);
        Cube cube21 = new Cube(55 , 145, 100);
        Cube cube22 = new Cube(100, 145, 100);
        Cube cube23 = new Cube(145, 145, 100);
        Cube cube24 = new Cube(55 , 145, 145);
        Cube cube25 = new Cube(100, 145, 145);
        Cube cube26 = new Cube(145, 145, 145);
        Cube[] cubes = new Cube[26];

        private void Form1_Load(object sender, EventArgs ea)
        {

            cubes[0] = cube1;
            cubes[1] = cube2;
            cubes[2] = cube3;
            cubes[3] = cube4;
            cubes[4] = cube5;
            cubes[5] = cube6;
            cubes[6] = cube7;
            cubes[7] = cube8;
            cubes[8] = cube9;
            cubes[9] = cube10;
            cubes[10] = cube11;
            cubes[11] = cube12;
            cubes[12] = cube13;
            cubes[13] = cube14;
            cubes[14] = cube15;
            cubes[15] = cube16;
            cubes[16] = cube17;
            cubes[17] = cube18;
            cubes[18] = cube19;
            cubes[19] = cube20;
            cubes[20] = cube21;
            cubes[21] = cube22;
            cubes[22] = cube23;
            cubes[23] = cube24;
            cubes[24] = cube25;
            cubes[25] = cube26;                 

            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(20);
                cube.RotateCubeX(20);
                grp.DrawLine(new Pen(Color.Black), cube.a[0], cube.a[1], cube.b[0], cube.b[1]);
                grp.DrawLine(new Pen(Color.Black), cube.c[0], cube.c[1], cube.b[0], cube.b[1]);
                grp.DrawLine(new Pen(Color.Black), cube.c[0], cube.c[1], cube.d[0], cube.d[1]);
                grp.DrawLine(new Pen(Color.Black), cube.a[0], cube.a[1], cube.d[0], cube.d[1]);

                grp.DrawLine(new Pen(Color.Black), cube.e[0], cube.e[1], cube.f[0], cube.f[1]);
                grp.DrawLine(new Pen(Color.Black), cube.g[0], cube.g[1], cube.f[0], cube.f[1]);
                grp.DrawLine(new Pen(Color.Black), cube.g[0], cube.g[1], cube.h[0], cube.h[1]);
                grp.DrawLine(new Pen(Color.Black), cube.e[0], cube.e[1], cube.h[0], cube.h[1]);

                grp.DrawLine(new Pen(Color.Black), cube.e[0], cube.e[1], cube.a[0], cube.a[1]);
                grp.DrawLine(new Pen(Color.Black), cube.b[0], cube.b[1], cube.f[0], cube.f[1]);
                grp.DrawLine(new Pen(Color.Black), cube.g[0], cube.g[1], cube.c[0], cube.c[1]);
                grp.DrawLine(new Pen(Color.Black), cube.d[0], cube.d[1], cube.h[0], cube.h[1]);
            }
            pictureBox1.Image = img;
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
                grp.FillPolygon(new SolidBrush(sideColor.color), sideColor.points);
                //grp.FillPolygon(new SolidBrush(Color.Black), sideColor.points);
            }
            pictureBox1.Image = img;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (trackBary.Value==360)
            {
                trackBary.Value = 0;
            }
            trackBary.Value++;
        }

        private void Smove_Click(object sender, EventArgs em)
        {
            if (timer3.Enabled == false) { 
            timer3.Start();
            }
            else
                timer3.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);

            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(trackBary.Value);
                /*if (cube.a[2] > 200)
                {*/
                    grp.DrawLine(new Pen(Color.Black), cube.e[0], cube.e[1], cube.a[0], cube.a[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.a[0], cube.a[1], cube.b[0], cube.b[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.a[0], cube.a[1], cube.d[0], cube.d[1]);
                /*{
                if (cube.c[2] > 200)
                {*/
                    grp.DrawLine(new Pen(Color.Black), cube.g[0], cube.g[1], cube.c[0], cube.c[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.c[0], cube.c[1], cube.b[0], cube.b[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.c[0], cube.c[1], cube.d[0], cube.d[1]);
                /*}                            
                if(cube.f[2] > 200) 
                {*/
                    grp.DrawLine(new Pen(Color.Black), cube.b[0], cube.b[1], cube.f[0], cube.f[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.g[0], cube.g[1], cube.f[0], cube.f[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.e[0], cube.e[1], cube.f[0], cube.f[1]);                    
                /*}
                if(cube.h[2] > 200)
                {*/
                    grp.DrawLine(new Pen(Color.Black), cube.e[0], cube.e[1], cube.h[0], cube.h[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.g[0], cube.g[1], cube.h[0], cube.h[1]);
                    grp.DrawLine(new Pen(Color.Black), cube.d[0], cube.d[1], cube.h[0], cube.h[1]);
                /*}*/
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
