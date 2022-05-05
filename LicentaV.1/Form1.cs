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
        private void timerFirstHalf()
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
        }
        private void timerSecondHalf()
        {
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
        }
        Graphics grp;
        Bitmap img;
        Cube cube1 = new Cube(10, 10, 10);
        Cube cube2 = new Cube(100, 10, 10);
        Cube cube3 = new Cube(190, 10, 10);
        Cube cube4 = new Cube(10, 10, 100);
        Cube cube5 = new Cube(100, 10, 100);
        Cube cube6 = new Cube(190, 10, 100);
        Cube cube7 = new Cube(10, 10, 190);
        Cube cube8 = new Cube(100, 10, 190);
        Cube cube9 = new Cube(190, 10, 190);
        Cube cube10 = new Cube(10, 100, 10);
        Cube cube11 = new Cube(100, 100, 10);
        Cube cube12 = new Cube(190, 100, 10);
        Cube cube13 = new Cube(10, 100, 100);
        Cube cube14 = new Cube(190, 100, 100);
        Cube cube15 = new Cube(10, 100, 190);
        Cube cube16 = new Cube(100, 100, 190);
        Cube cube17 = new Cube(190, 100, 190);
        Cube cube18 = new Cube(10, 190, 10);
        Cube cube19 = new Cube(100, 190, 10);
        Cube cube20 = new Cube(190, 190, 10);
        Cube cube21 = new Cube(10, 190, 100);
        Cube cube22 = new Cube(100, 190, 100);
        Cube cube23 = new Cube(190, 190, 100);
        Cube cube24 = new Cube(10, 190, 190);
        Cube cube25 = new Cube(100, 190, 190);
        Cube cube26 = new Cube(190, 190, 190);
        Cube[] cubes = new Cube[26];
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public void colorSquare(Cube cube)
        {
            Cube[] topCubes = 
                {
                    cubes[0],
                    cubes[1],
                    cubes[2],
                    cubes[3],
                    cubes[4],
                    cubes[5],
                    cubes[6],
                    cubes[7],
                    cubes[8]
                };
            Cube[] bottomCubes =
                {
                    cubes[17],
                    cubes[18],
                    cubes[19],
                    cubes[20],
                    cubes[21],
                    cubes[22],
                    cubes[23],
                    cubes[24],
                    cubes[25]
                };
            Cube[] leftCubes =
                {
                    cubes[0],
                    cubes[3],
                    cubes[6],
                    cubes[9],
                    cubes[12],
                    cubes[14],
                    cubes[17],
                    cubes[20],
                    cubes[23]
                };
            Cube[] rightCubes =
                {
                    cubes[2],
                    cubes[5],
                    cubes[8],
                    cubes[11],
                    cubes[13],
                    cubes[16],
                    cubes[19],
                    cubes[22],
                    cubes[25]
                };
            Cube[] frontCubes =
                {
                    cubes[6],
                    cubes[7],
                    cubes[8],
                    cubes[14],
                    cubes[15],
                    cubes[16],
                    cubes[23],
                    cubes[24],
                    cubes[25]
                };
            Cube[] backCubes =
                {
                    cubes[0],
                    cubes[1],
                    cubes[2],
                    cubes[9],
                    cubes[10],
                    cubes[11],
                    cubes[17],
                    cubes[18],
                    cubes[19]
                };
            float[] cubePoints =
                {
                    cube.a[2],
                    cube.b[2],
                    cube.c[2],
                    cube.d[2],
                    cube.e[2],
                    cube.f[2],
                    cube.g[2],
                    cube.h[2]
                };
            Array.Sort(cubePoints);

            if (cubePoints[7] == cube.a[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Yellow), cube.getBottom());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Green), cube.getFront());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.b[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.White), cube.getTop());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Green), cube.getFront());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.c[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.White), cube.getTop());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Blue), cube.getBack());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.d[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Yellow), cube.getBottom());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Blue), cube.getBack());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.e[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Yellow), cube.getBottom());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Orange), cube.getLeft());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Green), cube.getFront());
                }
            }
            if (cubePoints[7] == cube.f[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.White), cube.getTop());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Orange), cube.getLeft());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Green), cube.getFront());
                }
            }
            if (cubePoints[7] == cube.g[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.White), cube.getTop());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Orange), cube.getLeft());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Blue), cube.getBack());
                }
            }
            if (cubePoints[7] == cube.h[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Yellow), cube.getBottom());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Orange), cube.getLeft());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(Color.Blue), cube.getBack());
                }
            }           
        }
        public void colorCube()
        {
            foreach (Cube cube in cubes)
            {
                grp.FillPolygon(new SolidBrush(Color.Black), cube.getBottom());
                grp.FillPolygon(new SolidBrush(Color.Black), cube.getTop());
                grp.FillPolygon(new SolidBrush(Color.Black), cube.getFront());
                grp.FillPolygon(new SolidBrush(Color.Black), cube.getBack());
                grp.FillPolygon(new SolidBrush(Color.Black), cube.getLeft());
                grp.FillPolygon(new SolidBrush(Color.Black), cube.getRight());
            }
            float[] cubesArrayZ = new float[26];
            for (int i = 0; i < cubesArrayZ.Length; i++)
            {
                cubesArrayZ[i] = cubes[i].a[2];
            }
            Cube[] cubesArray = new Cube[26];
            for (int i = 0; i < cubesArrayZ.Length; i++)
            {
                cubesArray[i] = cubes[i];
            }
            for (int j = 0; j <= cubesArrayZ.Length - 2; j++)
            {
                for (int i = 0; i <= cubesArrayZ.Length - 2; i++)
                {
                    if (cubesArrayZ[i] > cubesArrayZ[i + 1])
                    {
                        float temp1 = cubesArrayZ[i + 1];
                        cubesArrayZ[i + 1] = cubesArrayZ[i];
                        cubesArrayZ[i] = temp1;
                        Cube temp2 = cubesArray[i + 1];
                        cubesArray[i + 1] = cubesArray[i];
                        cubesArray[i] = temp2;
                    }
                }
            }
            foreach (Cube cube in cubesArray)
            {
                colorSquare(cube);
            }
        }
        Cube[] topCubes;
        Cube[] bottomCubes;
        Cube[] frontCubes;
        Cube[] backCubes;
        Cube[] leftCubes;
        Cube[] rightCubes;
        Cube[] SCubes;
        Cube[] MCubes;
        Cube[] ECubes;

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

            Cube[] topCubes1 = { cube1, cube2, cube3, cube4, cube5, cube6, cube7, cube8, cube9 };
            Cube[] bottomCubes1 = { cube18, cube19, cube20, cube21, cube22, cube23, cube24, cube25, cube26 };
            Cube[] frontCubes1 = { cube7, cube8, cube9, cube15, cube16, cube17, cube24, cube25, cube26 };
            Cube[] backCubes1 = { cube1, cube2, cube3, cube10, cube11, cube12, cube18, cube19, cube20 };
            Cube[] leftCubes1 = { cube1, cube4, cube7, cube10, cube13, cube15, cube18, cube21, cube24 };
            Cube[] rightCubes1 = { cube3, cube6, cube9, cube12, cube14, cube17, cube20, cube23, cube26 };
            Cube[] SCubes1 = { cube4, cube5, cube6, cube13, cube14, cube21, cube22, cube23 };
            Cube[] MCubes1 = { cube2, cube5, cube8, cube11, cube16, cube19, cube22, cube25 };
            Cube[] ECubes1 = { cube10, cube11, cube12, cube13, cube14, cube15, cube16, cube17 };
            topCubes = topCubes1;
            bottomCubes = bottomCubes1;
            frontCubes = frontCubes1;
            backCubes = backCubes1;
            leftCubes = leftCubes1;
            rightCubes = rightCubes1;
            SCubes = SCubes1;
            ECubes = ECubes1;
            MCubes = MCubes1;

            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
        }
        private void rotateS()
        {
            Cube aux = SCubes[0];

            SCubes[0] = SCubes[5];
            SCubes[5] = SCubes[7];
            SCubes[7] = SCubes[2];
            SCubes[2] = aux;
            aux = SCubes[1];
            SCubes[1] = SCubes[3];
            SCubes[3] = SCubes[6];
            SCubes[6] = SCubes[4];
            SCubes[4] = aux;

            topCubes[3] = SCubes[0];
            topCubes[4] = SCubes[1];
            topCubes[5] = SCubes[2];

            rightCubes[1] = SCubes[2];
            rightCubes[4] = SCubes[4];
            rightCubes[7] = SCubes[7];

            bottomCubes[3] = SCubes[5];
            bottomCubes[4] = SCubes[6];
            bottomCubes[5] = SCubes[7];

            leftCubes[1] = SCubes[0];
            leftCubes[4] = SCubes[3];
            leftCubes[7] = SCubes[7];
        }
        private void rotateM()
        {
            Cube aux = MCubes[0];

            MCubes[0] = MCubes[5];
            MCubes[5] = MCubes[7];
            MCubes[7] = MCubes[2];
            MCubes[2] = aux;
            aux = MCubes[1];
            MCubes[1] = MCubes[3];
            MCubes[3] = MCubes[6];
            MCubes[6] = MCubes[4];
            MCubes[4] = aux;

            topCubes[1] = MCubes[0];
            topCubes[4] = MCubes[1];
            topCubes[7] = MCubes[2];

            backCubes[1] = MCubes[0];
            backCubes[4] = MCubes[3];
            backCubes[7] = MCubes[5];

            bottomCubes[1] = MCubes[5];
            bottomCubes[4] = MCubes[6];
            bottomCubes[7] = MCubes[7];

            frontCubes[1] = MCubes[2];
            frontCubes[4] = MCubes[4];
            frontCubes[7] = MCubes[7];
        }
        private void rotateE()
        {
            Cube aux = ECubes[0];

            ECubes[0] = ECubes[5];
            ECubes[5] = ECubes[7];
            ECubes[7] = ECubes[2];
            ECubes[2] = aux;
            aux = ECubes[1];
            ECubes[1] = ECubes[3];
            ECubes[3] = ECubes[6];
            ECubes[6] = ECubes[4];
            ECubes[4] = aux;

            leftCubes[3] = ECubes[0];
            leftCubes[4] = ECubes[3];
            leftCubes[5] = ECubes[5];

            backCubes[1] = ECubes[0];
            backCubes[4] = ECubes[1];
            backCubes[7] = ECubes[2];

            bottomCubes[1] = ECubes[5];
            bottomCubes[4] = ECubes[6];
            bottomCubes[7] = ECubes[7];

            rightCubes[1] = ECubes[2];
            rightCubes[4] = ECubes[4];
            rightCubes[7] = ECubes[7];
        }
        private void rotateDp()
        {
            Cube aux = bottomCubes[0];

            bottomCubes[0] = bottomCubes[6];
            bottomCubes[6] = bottomCubes[8];
            bottomCubes[8] = bottomCubes[2];
            bottomCubes[2] = aux;
            aux = bottomCubes[1];
            bottomCubes[1] = bottomCubes[3];
            bottomCubes[3] = bottomCubes[7];
            bottomCubes[7] = bottomCubes[5];
            bottomCubes[5] = aux;

            backCubes[6] = bottomCubes[0];
            backCubes[7] = bottomCubes[1];
            backCubes[8] = bottomCubes[2];

            rightCubes[6] = bottomCubes[2];
            rightCubes[7] = bottomCubes[5];
            rightCubes[8] = bottomCubes[8];

            frontCubes[6] = bottomCubes[6];
            frontCubes[7] = bottomCubes[7];
            frontCubes[8] = bottomCubes[8];

            leftCubes[6] = bottomCubes[0];
            leftCubes[7] = bottomCubes[3];
            leftCubes[8] = bottomCubes[6];

            SCubes[5] = bottomCubes[3];
            SCubes[6] = bottomCubes[4];
            SCubes[7] = bottomCubes[5];

            MCubes[5] = bottomCubes[1];
            MCubes[6] = bottomCubes[4];
            MCubes[7] = bottomCubes[7];

            ECubes[5] = bottomCubes[1];
            ECubes[6] = bottomCubes[4];
            ECubes[7] = bottomCubes[7];
        }
        private void rotateD()
        {
            Cube aux = bottomCubes[0];

            bottomCubes[0] = bottomCubes[2];
            bottomCubes[2] = bottomCubes[8];
            bottomCubes[8] = bottomCubes[6];
            bottomCubes[6] = aux;
            aux = bottomCubes[1];
            bottomCubes[1] = bottomCubes[5];
            bottomCubes[5] = bottomCubes[7];
            bottomCubes[7] = bottomCubes[3];
            bottomCubes[3] = aux;

            backCubes[6] = bottomCubes[0];
            backCubes[7] = bottomCubes[1];
            backCubes[8] = bottomCubes[2];

            rightCubes[6] = bottomCubes[2];
            rightCubes[7] = bottomCubes[5];
            rightCubes[8] = bottomCubes[8];

            frontCubes[6] = bottomCubes[6];
            frontCubes[7] = bottomCubes[7];
            frontCubes[8] = bottomCubes[8];

            leftCubes[6] = bottomCubes[0];
            leftCubes[7] = bottomCubes[3];
            leftCubes[8] = bottomCubes[6];

            SCubes[5] = bottomCubes[3];
            SCubes[6] = bottomCubes[4];
            SCubes[7] = bottomCubes[5];

            MCubes[5] = bottomCubes[1];
            MCubes[6] = bottomCubes[4];
            MCubes[7] = bottomCubes[7];

            ECubes[5] = bottomCubes[1];
            ECubes[6] = bottomCubes[4];
            ECubes[7] = bottomCubes[7];
        }
        private void rotateRp()
        {
            Cube aux = rightCubes[0];

            rightCubes[0] = rightCubes[6];
            rightCubes[6] = rightCubes[8];
            rightCubes[8] = rightCubes[2];
            rightCubes[2] = aux;
            aux = rightCubes[1];
            rightCubes[1] = rightCubes[3];
            rightCubes[3] = rightCubes[7];
            rightCubes[7] = rightCubes[5];
            rightCubes[5] = aux;

            backCubes[2] = rightCubes[0];
            backCubes[5] = rightCubes[3];
            backCubes[8] = rightCubes[6];

            topCubes[2] = rightCubes[0];
            topCubes[5] = rightCubes[1];
            topCubes[8] = rightCubes[2];

            frontCubes[2] = rightCubes[2];
            frontCubes[5] = rightCubes[5];
            frontCubes[8] = rightCubes[8];

            bottomCubes[2] = rightCubes[6];
            bottomCubes[5] = rightCubes[7];
            bottomCubes[8] = rightCubes[8];

            SCubes[2] = rightCubes[1];
            SCubes[4] = rightCubes[4];
            SCubes[7] = rightCubes[7];

            ECubes[2] = rightCubes[1];
            ECubes[4] = rightCubes[4];
            ECubes[7] = rightCubes[7];
        }
        private void rotateL()
        {
            Cube aux = leftCubes[0];

            leftCubes[0] = leftCubes[6];
            leftCubes[6] = leftCubes[8];
            leftCubes[8] = leftCubes[2];
            leftCubes[2] = aux;
            aux = leftCubes[1];
            leftCubes[1] = leftCubes[3];
            leftCubes[3] = leftCubes[7];
            leftCubes[7] = leftCubes[5];
            leftCubes[5] = aux;

            backCubes[0] = leftCubes[0];
            backCubes[3] = leftCubes[3];
            backCubes[6] = leftCubes[6];

            topCubes[0] = leftCubes[0];
            topCubes[3] = leftCubes[1];
            topCubes[6] = leftCubes[2];

            frontCubes[0] = leftCubes[2];
            frontCubes[3] = leftCubes[5];
            frontCubes[6] = leftCubes[8];

            bottomCubes[0] = leftCubes[6];
            bottomCubes[3] = leftCubes[7];
            bottomCubes[6] = leftCubes[8];

            SCubes[0] = leftCubes[1];
            SCubes[3] = leftCubes[4];
            SCubes[5] = leftCubes[7];
        }
        private void rotateLp()
        {
            Cube aux = leftCubes[0];

            leftCubes[0] = leftCubes[2];
            leftCubes[2] = leftCubes[8];
            leftCubes[8] = leftCubes[6];
            leftCubes[6] = aux;
            aux = leftCubes[1];
            leftCubes[1] = leftCubes[5];
            leftCubes[5] = leftCubes[7];
            leftCubes[7] = leftCubes[3];
            leftCubes[3] = aux;

            backCubes[0] = leftCubes[0];
            backCubes[3] = leftCubes[3];
            backCubes[6] = leftCubes[6];

            topCubes[0] = leftCubes[0];
            topCubes[3] = leftCubes[1];
            topCubes[6] = leftCubes[2];

            frontCubes[0] = leftCubes[2];
            frontCubes[3] = leftCubes[5];
            frontCubes[6] = leftCubes[8];

            bottomCubes[0] = leftCubes[6];
            bottomCubes[3] = leftCubes[7];
            bottomCubes[6] = leftCubes[8];

            SCubes[0] = leftCubes[1];
            SCubes[3] = leftCubes[4];
            SCubes[5] = leftCubes[7];
        }
        private void rotateR()
        {
            Cube aux = rightCubes[0];            

            rightCubes[0] = rightCubes[2];
            rightCubes[2] = rightCubes[8];
            rightCubes[8] = rightCubes[6];
            rightCubes[6] = aux;
            aux = rightCubes[1];
            rightCubes[1] = rightCubes[5];
            rightCubes[5] = rightCubes[7];
            rightCubes[7] = rightCubes[3];
            rightCubes[3] = aux;

            backCubes[2] = rightCubes[0];
            backCubes[5] = rightCubes[3];
            backCubes[8] = rightCubes[6];

            topCubes[2] = rightCubes[0];
            topCubes[5] = rightCubes[1];
            topCubes[8] = rightCubes[2];

            frontCubes[2] = rightCubes[2];
            frontCubes[5] = rightCubes[5];
            frontCubes[8] = rightCubes[8];

            bottomCubes[2] = rightCubes[6];
            bottomCubes[5] = rightCubes[7];
            bottomCubes[8] = rightCubes[8];

            SCubes[2] = rightCubes[1];
            SCubes[4] = rightCubes[4];
            SCubes[7] = rightCubes[7];

            ECubes[2] = rightCubes[1];
            ECubes[4] = rightCubes[4];
            ECubes[7] = rightCubes[7];
        }
        private void rotateU()
        {
            Cube aux = topCubes[0];
            topCubes[0] = topCubes[6];
            topCubes[6] = topCubes[8];
            topCubes[8] = topCubes[2];
            topCubes[2] = aux;
            aux = topCubes[1];
            topCubes[1] = topCubes[3];            
            topCubes[3] = topCubes[7];
            topCubes[7] = topCubes[5];
            topCubes[5] = aux;

            backCubes[0] = topCubes[0];
            backCubes[1] = topCubes[1];
            backCubes[2] = topCubes[2];

            rightCubes[0] = topCubes[2];
            rightCubes[1] = topCubes[5];
            rightCubes[2] = topCubes[8];

            frontCubes[0] = topCubes[6];
            frontCubes[1] = topCubes[7];
            frontCubes[2] = topCubes[8];

            leftCubes[0] = topCubes[0];
            leftCubes[1] = topCubes[3];
            leftCubes[2] = topCubes[6];

            SCubes[0] = topCubes[3];
            SCubes[1] = topCubes[4];
            SCubes[2] = topCubes[5];

            MCubes[0] = topCubes[1];
            MCubes[1] = topCubes[4];
            MCubes[2] = topCubes[7];
        }
        private void rotateUp()
        {
            Cube aux = topCubes[0];

            topCubes[0] = topCubes[2];
            topCubes[2] = topCubes[8];
            topCubes[8] = topCubes[6];
            topCubes[6] = aux;
            aux = topCubes[1];
            topCubes[1] = topCubes[5];
            topCubes[5] = topCubes[7];
            topCubes[7] = topCubes[3];
            topCubes[3] = aux;

            backCubes[0] = topCubes[0];
            backCubes[1] = topCubes[1];
            backCubes[2] = topCubes[2];

            rightCubes[0] = topCubes[2];
            rightCubes[1] = topCubes[5];
            rightCubes[2] = topCubes[8];

            frontCubes[0] = topCubes[6];
            frontCubes[1] = topCubes[7];
            frontCubes[2] = topCubes[8];

            leftCubes[0] = topCubes[0];
            leftCubes[1] = topCubes[3];
            leftCubes[2] = topCubes[6];

            SCubes[0] = topCubes[3];
            SCubes[1] = topCubes[4];
            SCubes[2] = topCubes[5];

            MCubes[0] = topCubes[1];
            MCubes[1] = topCubes[4];
            MCubes[2] = topCubes[7];
        }
        private void rotateF()
        {
            Cube aux = frontCubes[0];

            frontCubes[0] = frontCubes[6];
            frontCubes[6] = frontCubes[8];
            frontCubes[8] = frontCubes[2];
            frontCubes[2] = aux;
            aux = frontCubes[1];
            frontCubes[1] = frontCubes[3];
            frontCubes[3] = frontCubes[7];
            frontCubes[7] = frontCubes[5];
            frontCubes[5] = aux;

            topCubes[6] = frontCubes[0];
            topCubes[7] = frontCubes[1];
            topCubes[8] = frontCubes[2];

            rightCubes[2] = frontCubes[2];
            rightCubes[5] = frontCubes[5];
            rightCubes[8] = frontCubes[8];

            bottomCubes[6] = frontCubes[6];
            bottomCubes[7] = frontCubes[7];
            bottomCubes[8] = frontCubes[8];

            leftCubes[2] = frontCubes[0];
            leftCubes[5] = frontCubes[3];
            leftCubes[8] = frontCubes[6];

            MCubes[2] = frontCubes[1];
            MCubes[4] = frontCubes[4];
            MCubes[6] = frontCubes[7];

            ECubes[0] = leftCubes[3];
            ECubes[3] = leftCubes[4];
            ECubes[5] = leftCubes[5];
        }
        private void rotateFp()
        {
            Cube aux = frontCubes[0];

            frontCubes[0] = frontCubes[2];
            frontCubes[2] = frontCubes[8];
            frontCubes[8] = frontCubes[6];
            frontCubes[6] = aux;
            aux = frontCubes[1];
            frontCubes[1] = frontCubes[5];
            frontCubes[5] = frontCubes[7];
            frontCubes[7] = frontCubes[3];
            frontCubes[3] = aux;

            topCubes[6] = frontCubes[0];
            topCubes[7] = frontCubes[1];
            topCubes[8] = frontCubes[2];

            rightCubes[2] = frontCubes[2];
            rightCubes[5] = frontCubes[5];
            rightCubes[8] = frontCubes[8];

            bottomCubes[6] = frontCubes[6];
            bottomCubes[7] = frontCubes[7];
            bottomCubes[8] = frontCubes[8];

            leftCubes[2] = frontCubes[0];
            leftCubes[5] = frontCubes[3];
            leftCubes[8] = frontCubes[6];

            MCubes[2] = frontCubes[1];
            MCubes[4] = frontCubes[4];
            MCubes[6] = frontCubes[7];

            ECubes[0] = leftCubes[3];
            ECubes[3] = leftCubes[4];
            ECubes[5] = leftCubes[5];
        }
        private void rotateB()
        {
            Cube aux = backCubes[0];
            
            backCubes[0] = backCubes[2];
            backCubes[2] = backCubes[8];
            backCubes[8] = backCubes[6];
            backCubes[6] = aux;
            aux = backCubes[1];
            backCubes[1] = backCubes[5];
            backCubes[5] = backCubes[7];
            backCubes[7] = backCubes[3];
            backCubes[3] = aux;

            topCubes[0] = backCubes[0];
            topCubes[1] = backCubes[1];
            topCubes[2] = backCubes[2];

            rightCubes[0] = backCubes[2];
            rightCubes[3] = backCubes[5];
            rightCubes[6] = backCubes[8];

            bottomCubes[0] = backCubes[6];
            bottomCubes[1] = backCubes[7];
            bottomCubes[2] = backCubes[8];

            leftCubes[0] = backCubes[0];
            leftCubes[3] = backCubes[3];
            leftCubes[6] = backCubes[6];

            MCubes[0] = backCubes[1];
            MCubes[3] = backCubes[4];
            MCubes[5] = backCubes[7];

            ECubes[0] = backCubes[1];
            ECubes[1] = backCubes[4];
            ECubes[2] = backCubes[7];
        }
        private void rotateBp()
        {
            Cube aux = backCubes[0];

            backCubes[0] = backCubes[6];
            backCubes[6] = backCubes[8];
            backCubes[8] = backCubes[2];
            backCubes[2] = aux;
            aux = backCubes[1];
            backCubes[1] = backCubes[3];
            backCubes[3] = backCubes[7];
            backCubes[7] = backCubes[5];
            backCubes[5] = aux;

            topCubes[0] = backCubes[0];
            topCubes[1] = backCubes[1];
            topCubes[2] = backCubes[2];

            rightCubes[0] = backCubes[2];
            rightCubes[3] = backCubes[5];
            rightCubes[6] = backCubes[8];

            bottomCubes[0] = backCubes[6];
            bottomCubes[1] = backCubes[7];
            bottomCubes[2] = backCubes[8];

            leftCubes[0] = backCubes[0];
            leftCubes[3] = backCubes[3];
            leftCubes[6] = backCubes[6];

            MCubes[0] = backCubes[1];
            MCubes[3] = backCubes[4];
            MCubes[5] = backCubes[7];

            ECubes[0] = backCubes[1];
            ECubes[1] = backCubes[4];
            ECubes[2] = backCubes[7];
        }
        private void rotateX()
        {
            rotateM();
            rotateM();
            rotateM();
            rotateR();
            rotateLp();
        }
        private void rotateY()
        {
            rotateE();
            rotateE();
            rotateE();
            rotateU();
            rotateBp();
        }
        private void rotateZ()
        {
            rotateBp();
            rotateS();
            rotateF();
        }
        private void Smove_Click(object sender, EventArgs em)
        {
            SmoveTimer.Start();            
        }
        private void BpMove_Click(object sender, EventArgs e)
        {
            BpMoveTimer.Start();
        }
        private void Bmove_Click(object sender, EventArgs e)
        {
            BmoveTimer.Start();
        }
        private void LpMove_Click(object sender, EventArgs e)
        {
            LpMoveTimer.Start();
        }
        private void Lmove_Click(object sender, EventArgs e)
        {
            LmoveTimer.Start();
        }
        private void Umove_Click(object sender, EventArgs e)
        {           
            UmoveTimer.Start();
        }
        private void UpMove_Click(object sender, EventArgs e)
        {
            UpMoveTimer.Start();
        }
        private void Dmove_Click(object sender, EventArgs e)
        {
            DmoveTimer.Start();
        }
        private void DpMove_Click(object sender, EventArgs e)
        {
            DpMoveTimer.Start();
        }
        private void Rmove_Click(object sender, EventArgs e)
        {
            RmoveTimer.Start();
        }
        private void Fmove_Click(object sender, EventArgs e)
        {
            FmoveTimer.Start();
        }
        private void RpMove_Click(object sender, EventArgs e)
        {
            RpMoveTimer.Start();
        }
        private void FpMove_Click(object sender, EventArgs e)
        {
            FpMoveTimer.Start();
        }
        private void Xmove_Click(object sender, EventArgs e)
        {
            XmoveTimer.Start();
        }
        private void Zmove_Click(object sender, EventArgs e)
        {
            ZmoveTimer.Start();
        }
        private void Ymove_Click(object sender, EventArgs e)
        {
            YmoveTimer.Start();
        }
        private void L2_Click(object sender, EventArgs e)
        {
            LmoveTimer.Start();
            wait(200);
            LmoveTimer.Start();
        }

        private void U2_Click(object sender, EventArgs e)
        {
            UmoveTimer.Start();
            wait(200);
            UmoveTimer.Start();
        }
        private void Emove_Click(object sender, EventArgs e)
        {
            EmoveTimer.Start();
        }

        private void F2_Click(object sender, EventArgs e)
        {
            FmoveTimer.Start();
            wait(200);
            FmoveTimer.Start();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            BmoveTimer.Start();
            wait(200);
            BmoveTimer.Start();
        }

        private void D2_Click(object sender, EventArgs e)
        {
            DmoveTimer.Start();
            wait(200);
            DmoveTimer.Start();
        }

        private void R2_Click(object sender, EventArgs e)
        {
            RmoveTimer.Start();
            wait(200);
            RmoveTimer.Start();
        }
        private void Mmove_Click(object sender, EventArgs e)
        {
            MmoveTimer.Start();
        }
        int cws = 90;
        int ccws = 0;
        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateUp();
                ccws = 0;
                UpMoveTimer.Stop();
            }
        }

        private void UmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateU();
                cws = 90;
                UmoveTimer.Stop();
            }
        }        
        private void DmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateD();
                ccws = 0;
                DmoveTimer.Stop();
            }
        }

        private void DpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateDp();
                cws = 90;
                DpMoveTimer.Stop();
            }
        }
        private void RmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateR();
                ccws = 0;
                RmoveTimer.Stop();
            }
        }

        private void RpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateRp();
                cws = 90;
                RpMoveTimer.Stop();
            }
        }

        private void FmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in frontCubes)
            {
                cube.RotateCubeZ(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateF();
                ccws = 0;
                FmoveTimer.Stop();
            }
        }

        private void FpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in frontCubes)
            {
                cube.RotateCubeZ(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateFp();
                cws = 90;
                FpMoveTimer.Stop();
            }
        }

        private void XmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateX();
                ccws = 0;
                XmoveTimer.Stop();
            }
        }

        private void YmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateY();
                cws = 90;
                YmoveTimer.Stop();
            }
        }

        private void ZmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeZ(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateZ();
                ccws = 0;
                ZmoveTimer.Stop();
            }
        }

        private void LmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in leftCubes)
            {
                cube.RotateCubeX(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateL();
                cws = 90;
                LmoveTimer.Stop();
            }
        }

        private void LpMovetimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in leftCubes)
            {
                cube.RotateCubeX(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateLp();
                ccws = 0;
                LpMoveTimer.Stop();
            }
        }

        private void BmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in backCubes)
            {
                cube.RotateCubeZ(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateB();
                cws = 90;
                BmoveTimer.Stop();
            }
        }

        private void BpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in backCubes)
            {
                cube.RotateCubeZ(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateBp();
                ccws = 0;
                BpMoveTimer.Stop();
            }
        }
        string scrambleOutput;
        private void Scramble_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(6); ;
            switch (randomNumber)
            {
                case 0:
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = randomGenerator.Next(6);
                        randomUDMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomRLMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomFBMove(randomNumber);
                    }
                    break;
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = randomGenerator.Next(6);
                        randomUDMove(randomNumber);                       
                        randomNumber = randomGenerator.Next(6);
                        randomFBMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomRLMove(randomNumber);
                    }
                    break;
                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = randomGenerator.Next(6);
                        randomRLMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomUDMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomFBMove(randomNumber);
                    }
                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = randomGenerator.Next(6);
                        randomRLMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomFBMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomUDMove(randomNumber);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = randomGenerator.Next(6);
                        randomFBMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomUDMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomRLMove(randomNumber);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = randomGenerator.Next(6);
                        randomFBMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomRLMove(randomNumber);
                        randomNumber = randomGenerator.Next(6);
                        randomUDMove(randomNumber);                        
                    }
                    break;                
            }
            label1.Visible = true;
            label1.Text = scrambleOutput;
            scrambleOutput = "";
        }
        private void randomRLMove(int randomNumber)
        {

            switch (randomNumber)
            {                
                case 0:
                    LmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " L";
                    break;
                case 1:
                    LpMoveTimer.Start();
                    wait(200);
                    scrambleOutput += " L'";
                    break;
                case 2:
                    RmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " R";
                    break;
                case 3:
                    RpMoveTimer.Start();
                    wait(200);
                    scrambleOutput += " R'";
                    break;
                case 4:
                    RmoveTimer.Start();
                    wait(200); 
                    RmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " R2";
                    break;
                case 5:
                    LmoveTimer.Start();
                    wait(200); 
                    LmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " L2";
                    break;
            }
        }
        private void randomUDMove(int randomNumber)
        {

            switch (randomNumber)
            {

                case 0:
                    UmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " U";
                    break;
                case 1:
                    UpMoveTimer.Start();
                    wait(200);
                    scrambleOutput += " U'";
                    break;
                case 2:
                    DmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " D";
                    break;
                case 3:
                    DpMoveTimer.Start();
                    wait(200);
                    scrambleOutput += " D'";
                    break;
                case 4:
                    UmoveTimer.Start();
                    wait(200);
                    UmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " U2";
                    break;
                case 5:
                    DmoveTimer.Start();
                    wait(200);
                    DmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " D2";
                    break;
            }
        }
        private void randomFBMove(int randomNumber)
        {

            switch (randomNumber)
            {                             
                case 0:
                    BmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " B";
                    break;
                case 1:
                    BpMoveTimer.Start();
                    wait(200);
                    scrambleOutput += " B'";
                    break;
                case 2:
                    FmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " F";
                    break;
                case 3:
                    FpMoveTimer.Start();
                    wait(200);
                    scrambleOutput += " F'";
                    break;
                case 4:
                    BmoveTimer.Start();
                    wait(200);
                    BmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " B2";
                    break;
                case 5:
                    FmoveTimer.Start();
                    wait(200);
                    FmoveTimer.Start();
                    wait(200);
                    scrambleOutput += " F2";
                    break;
            }
        }

        private void SmoveTimer_Tick(object sender, EventArgs e)
        {

            timerFirstHalf();
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(10);
            }
            timerSecondHalf();
            ccws += 10;
            if (ccws == 90)
            {
                rotateS();
                ccws = 0;
                SmoveTimer.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* R U R' U' R' F R2 U' R' U' R U R' F*/
            RmoveTimer.Start();
            wait(200);
            UmoveTimer.Start();
            wait(200);
            RpMoveTimer.Start();
            wait(200);
            UpMoveTimer.Start();
            wait(200);
            RpMoveTimer.Start();
            wait(200);
            FmoveTimer.Start();
            wait(200);
            RmoveTimer.Start();
            wait(200);
            RmoveTimer.Start();
            wait(200);
            UpMoveTimer.Start();
            wait(200);
            RpMoveTimer.Start();
            wait(200);
            UpMoveTimer.Start();
            wait(200);
            RmoveTimer.Start();
            wait(200);
            UmoveTimer.Start();
            wait(200);
            RpMoveTimer.Start();
            wait(200);
            FpMoveTimer.Start();
            wait(200);
        }

        private void MmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateM();
                cws = 90;
                MmoveTimer.Stop();
            }
        }

        private void EmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(-10);
            }
            timerSecondHalf();
            cws -= 10;
            if (cws == 0)
            {
                rotateE();
                cws = 90;
                EmoveTimer.Stop();
            }
        }
    }
}
