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
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
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

        int UmoveAnimation = 90;
        int UpMoveAnimation = 0;
        int DmoveAnimation = 0;
        int DpMoveAnimation = 90;

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
            for (int i = 0; i < 9; i++)
            {
                cubes[i].RotateCubeY(-10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
            UmoveAnimation -= 10;
            if (UmoveAnimation == 0)
            {
                UmoveAnimation = 90;
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
            for (int i = 0; i < 9; i++)
            {
                cubes[i].RotateCubeY(10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
            UpMoveAnimation += 10;
            if (UpMoveAnimation == 90)
            {
                UpMoveAnimation = 0;
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
            for (int i = 17; i < 26; i++)
            {
                cubes[i].RotateCubeY(10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
            DmoveAnimation += 10;
            if (DmoveAnimation == 90)
            {
                DmoveAnimation = 0;
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
            for (int i = 17; i < 26; i++)
            {
                cubes[i].RotateCubeY(-10);
            }
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            pictureBox1.Image = img;
            DpMoveAnimation -= 10;
            if (DpMoveAnimation == 0)
            {
                DpMoveAnimation = 90;
                DpMoveTimer.Stop();
            }
        }
    }
}
