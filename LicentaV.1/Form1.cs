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

            topCubes = topCubes1;
            bottomCubes = bottomCubes1;
            frontCubes = frontCubes1;
            backCubes = backCubes1;
            leftCubes = leftCubes1;
            rightCubes = rightCubes1;

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
        private void rotateRp()
        {
            Cube aux0 = rightCubes[0];
            Cube aux1 = rightCubes[1];

            rightCubes[0] = rightCubes[6];
            rightCubes[6] = rightCubes[8];
            rightCubes[8] = rightCubes[2];
            rightCubes[2] = aux0;
            rightCubes[1] = rightCubes[3];
            rightCubes[3] = rightCubes[7];
            rightCubes[7] = rightCubes[5];
            rightCubes[5] = aux1;

            backCubes[2] = rightCubes[0];
            backCubes[5] = rightCubes[3];
            backCubes[8] = rightCubes[6];

            topCubes[2] = rightCubes[0];
            topCubes[5] = rightCubes[1];
            topCubes[8] = rightCubes[2];

            frontCubes[2] = rightCubes[2];
            frontCubes[5] = rightCubes[5];
            frontCubes[8] = rightCubes[8];

            bottomCubes[2] = topCubes[6];
            bottomCubes[5] = topCubes[7];
            bottomCubes[8] = topCubes[8];
        }
        private void rotateR()
        {
            Cube aux0 = rightCubes[0];
            Cube aux1 = rightCubes[1];

            rightCubes[0] = rightCubes[2];
            rightCubes[2] = rightCubes[8];
            rightCubes[8] = rightCubes[6];
            rightCubes[6] = aux0;
            rightCubes[1] = rightCubes[5];
            rightCubes[5] = rightCubes[7];
            rightCubes[7] = rightCubes[3];
            rightCubes[3] = aux1;

            backCubes[2] = rightCubes[0];
            backCubes[5] = rightCubes[3];
            backCubes[8] = rightCubes[6];

            topCubes[2] = rightCubes[0];
            topCubes[5] = rightCubes[1];
            topCubes[8] = rightCubes[2];

            frontCubes[2] = rightCubes[2];
            frontCubes[5] = rightCubes[5];
            frontCubes[8] = rightCubes[8];

            bottomCubes[2] = topCubes[6];
            bottomCubes[5] = topCubes[7];
            bottomCubes[8] = topCubes[8];
        }
        private void rotateU()
        {
            Cube aux0 = topCubes[0];
            Cube aux1 = topCubes[1];

            topCubes[0] = topCubes[6];
            topCubes[6] = topCubes[8];
            topCubes[8] = topCubes[2];
            topCubes[2] = aux0;            
            topCubes[1] = topCubes[3];            
            topCubes[3] = topCubes[7];
            topCubes[7] = topCubes[5];
            topCubes[5] = aux1;

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
        }
        private void rotateUp()
        {
            Cube aux0 = topCubes[0];
            Cube aux1 = topCubes[1];

            topCubes[0] = topCubes[2];
            topCubes[2] = topCubes[8];
            topCubes[8] = topCubes[6];
            topCubes[6] = aux0;
            topCubes[1] = topCubes[5];
            topCubes[5] = topCubes[7];
            topCubes[7] = topCubes[3];
            topCubes[3] = aux1;

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
        }
        private void Smove_Click(object sender, EventArgs em)
        {
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

        private void RpMove_Click(object sender, EventArgs e)
        {
            RpMoveTimer.Start();
        }
        int cws = 90;
        int ccws = 0;        

        private void UmoveTimer_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(-10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            rotateU();
            colorCube();
            pictureBox1.Image = img;
            cws -= 10;
            if (cws == 0)
            {
                cws = 90;
                UmoveTimer.Stop();
            }
        }        
        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
            foreach(Cube cube in topCubes)
            {
                cube.RotateCubeY(10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            rotateUp();
            colorCube();
            pictureBox1.Image = img;
            ccws += 10;
            if (ccws == 90)
            {
                ccws = 0;
                UpMoveTimer.Stop();
            }
        }

        private void DmoveTimer_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
            ccws += 10;
            if (ccws == 90)
            {
                ccws = 0;
                DmoveTimer.Stop();
            }
        }

        private void DpMoveTimer_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(-10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
            cws -= 10;
            if (cws == 0)
            {
                cws = 90;
                DpMoveTimer.Stop();
            }
        }


        private void RmoveTimer_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            rotateR();
            colorCube();
            pictureBox1.Image = img;
            ccws += 10;
            if (ccws == 90)
            {
                ccws = 0;
                RmoveTimer.Stop();
            }
        }

        private void RpMoveTimer_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(Color.DimGray);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(20);
                cube.RotateCubeY(20);
            }
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(-10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            rotateRp();
            colorCube();
            pictureBox1.Image = img;
            cws -= 10;
            if (cws == 0)
            {
                cws = 90;
                RpMoveTimer.Stop();
            }
        }
    }
}
