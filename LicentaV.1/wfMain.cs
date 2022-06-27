using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSimulator
{
    public partial class wfMain : Form
    {
        #region declarations
        int frameAngle = 10; // Avaliable 1,2,3,5,6,9,10,15,18,30,45,90
        int waitingTime = 200; // Recomanded 200 for every frameAngle (for 90 1 will be enough)
        int turningSpeed = 1;
        string scrambleOutput;
        int angle90 = 0;
        Graphics grp;
        Bitmap img;
        Cube[] topCubes;
        Cube[] bottomCubes;
        Cube[] frontCubes;
        Cube[] backCubes;
        Cube[] leftCubes;
        Cube[] rightCubes;
        Cube[] SCubes;
        Cube[] MCubes;
        Cube[] ECubes;
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
        Color white = Color.Gray;
        Color yellow = Color.FromArgb(170,170,0);
        Color red = Color.DarkRed;
        Color orange = Color.FromArgb(160, 100, 20);
        Color green = Color.DarkGreen;
        Color blue = Color.DarkBlue;

        Color backgroundColor = Color.FromArgb(71,44,44);

        readonly string[,] whiteFace =
        {
            { "Ac", "As", "Bc" },
            { "Ds", "0", "Bs" },
            { "Dc", "Cs", "Cc" }
        };
        readonly string[,] orangeFace =
{
            { "Ec", "Es", "Fc" },
            { "Hs", "1", "Fs" },
            { "Hc", "Gs", "Gc" }
        };
        readonly string[,] greenFace =
{
            { "Ic", "Is", "Jc" },
            { "Ls", "2", "Js" },
            { "Lc", "Ks",  "Kc"}
        };
        readonly string[,] redFace =
        {
            { "Mc", "Ms", "Nc" },
            { "Ps", "3", "Ns" },
            { "Pc", "Os", "Oc" }
        };
        readonly string[,] blueFace =
        {
            { "Qc", "Qs", "Rc" },
            { "Ts", "4", "Rs" },
            { "Tc", "Ss", "Sc" }
        };
        readonly string[,] yellowFace =
{
            { "Uc", "Us", "Vc" },
            { "Xs", "5", "Vs" },
            { "Xc", "Ws", "Wc" }
        };
        string[,] topFace =
        {
            { "Ac", "As", "Bc" },
            { "Ds", "0", "Bs" },
            { "Dc", "Cs", "Cc" }
        };
        string[,] leftFace =
{
            { "Ec", "Es", "Fc" },
            { "Hs", "1", "Fs" },
            { "Hc", "Gs", "Gc" }
        };
        string[,] frontFace =
{
            { "Ic", "Is", "Jc" },
            { "Ls", "2", "Js" },
            { "Lc", "Ks",  "Kc"}
        };
        string[,] rightFace =
        {
            { "Mc", "Ms", "Nc" },
            { "Ps", "3", "Ns" },
            { "Pc", "Os", "Oc" }
        };
        string[,] backFace =
        {
            { "Qc", "Qs", "Rc" },
            { "Ts", "4", "Rs" },
            { "Tc", "Ss", "Sc" }
        };
        string[,] bottomFace =
{
            { "Uc", "Us", "Vc" },
            { "Xs", "5", "Vs" },
            { "Xc", "Ws", "Wc" }
        };
        #endregion

        public wfMain()
        {            
            InitializeComponent();
        }
        private void wfMain_Load(object sender, EventArgs ea)
        {
            this.BackColor = backgroundColor;
            UmoveTimer. Interval = turningSpeed;
            LmoveTimer. Interval = turningSpeed;
            FmoveTimer. Interval = turningSpeed;
            RmoveTimer. Interval = turningSpeed;
            BmoveTimer. Interval = turningSpeed;
            DmoveTimer. Interval = turningSpeed;
            UpMoveTimer.Interval = turningSpeed;
            LpMoveTimer.Interval = turningSpeed;
            FpMoveTimer.Interval = turningSpeed;
            RpMoveTimer.Interval = turningSpeed;
            BpMoveTimer.Interval = turningSpeed;
            DpMoveTimer.Interval = turningSpeed;
            SmoveTimer. Interval = turningSpeed;
            EmoveTimer. Interval = turningSpeed;
            MmoveTimer. Interval = turningSpeed;
            SpMoveTimer.Interval = turningSpeed;
            EpMoveTimer.Interval = turningSpeed;
            MpMoveTimer.Interval = turningSpeed;
            XmoveTimer. Interval = turningSpeed;
            YmoveTimer. Interval = turningSpeed;
            ZmoveTimer. Interval = turningSpeed;

            cubes[0]  = cube1;
            cubes[1]  = cube2;
            cubes[2]  = cube3;
            cubes[3]  = cube4;
            cubes[4]  = cube5;
            cubes[5]  = cube6;
            cubes[6]  = cube7;
            cubes[7]  = cube8;
            cubes[8]  = cube9;
            cubes[9]  = cube10;
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

            Cube[] topCubesAux    = { cube1, cube2, cube3, cube4, cube5, cube6, cube7, cube8, cube9 };
            Cube[] bottomCubesAux = { cube18, cube19, cube20, cube21, cube22, cube23, cube24, cube25, cube26 };
            Cube[] frontCubesAux  = { cube7, cube8, cube9, cube15, cube16, cube17, cube24, cube25, cube26 };
            Cube[] backCubesAux   = { cube1, cube2, cube3, cube10, cube11, cube12, cube18, cube19, cube20 };
            Cube[] leftCubesAux   = { cube1, cube4, cube7, cube10, cube13, cube15, cube18, cube21, cube24 };
            Cube[] rightCubesAux  = { cube3, cube6, cube9, cube12, cube14, cube17, cube20, cube23, cube26 };
            Cube[] SCubesAux      = { cube4, cube5, cube6, cube13, cube14, cube21, cube22, cube23 };
            Cube[] MCubesAux      = { cube2, cube5, cube8, cube11, cube16, cube19, cube22, cube25 };
            Cube[] ECubesAux      = { cube10, cube11, cube12, cube13, cube14, cube15, cube16, cube17 };

            topCubes    = topCubesAux;
            bottomCubes = bottomCubesAux;
            frontCubes  = frontCubesAux;
            backCubes   = backCubesAux;
            leftCubes   = leftCubesAux;
            rightCubes  = rightCubesAux;
            SCubes      = SCubesAux;
            ECubes      = ECubesAux;
            MCubes      = MCubesAux;

            img = new Bitmap(canvas.Width, canvas.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(backgroundColor);
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-20);
                cube.RotateCubeX(-20);
            }
            colorCube();
            canvas.Image = img;
        }
        private void timerFirstHalf()
        {
            img = new Bitmap(canvas.Width, canvas.Height);
            grp = Graphics.FromImage(img);
            grp.Clear(backgroundColor);
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
            canvas.Image = img;
        }
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

        #region coloring
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
                    grp.FillPolygon(new SolidBrush(yellow), cube.getBottom());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(green), cube.getFront());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.b[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(white), cube.getTop());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(green), cube.getFront());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.c[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(white), cube.getTop());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(blue), cube.getBack());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.d[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(yellow), cube.getBottom());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(blue), cube.getBack());
                }
                if (rightCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(red), cube.getRight());
                }
            }
            if (cubePoints[7] == cube.e[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(yellow), cube.getBottom());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(orange), cube.getLeft());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(green), cube.getFront());
                }
            }
            if (cubePoints[7] == cube.f[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(white), cube.getTop());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(orange), cube.getLeft());
                }
                if (frontCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(green), cube.getFront());
                }
            }
            if (cubePoints[7] == cube.g[2])
            {
                if (topCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(white), cube.getTop());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(orange), cube.getLeft());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(blue), cube.getBack());
                }
            }
            if (cubePoints[7] == cube.h[2])
            {
                if (bottomCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(yellow), cube.getBottom());
                }
                if (leftCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(orange), cube.getLeft());
                }
                if (backCubes.Contains(cube))
                {
                    grp.FillPolygon(new SolidBrush(blue), cube.getBack());
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
        #endregion

        #region rotate      
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

            string auxFace = topFace[0, 0];

            topFace[0, 0] = topFace[2, 0];
            topFace[2, 0] = topFace[2, 2];
            topFace[2, 2] = topFace[0, 2];
            topFace[0, 2] = auxFace;

            auxFace = topFace[0, 1];

            topFace[0, 1] = topFace[1, 0];
            topFace[1, 0] = topFace[2, 1];
            topFace[2, 1] = topFace[1, 2];
            topFace[1, 2] = auxFace;

            auxFace = leftFace[0, 0];

            leftFace[0, 0] = frontFace[0, 0];
            frontFace[0, 0] = rightFace[0, 0];
            rightFace[0, 0] = backFace[0, 0];
            backFace[0, 0] = auxFace;

            auxFace = leftFace[0, 1];

            leftFace[0, 1] = frontFace[0, 1];
            frontFace[0, 1] = rightFace[0, 1];
            rightFace[0, 1] = backFace[0, 1];
            backFace[0, 1] = auxFace;

            auxFace = leftFace[0, 2];

            leftFace[0, 2] = frontFace[0, 2];
            frontFace[0, 2] = rightFace[0, 2];
            rightFace[0, 2] = backFace[0, 2];
            backFace[0, 2] = auxFace;
        }
        private void rotateUp()
        {

            rotateU();
            rotateU();
            rotateU();
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

            string auxFace = bottomFace[0, 0];

            bottomFace[0, 0] = bottomFace[2, 0];
            bottomFace[2, 0] = bottomFace[2, 2];
            bottomFace[2, 2] = bottomFace[0, 2];
            bottomFace[0, 2] = auxFace;

            auxFace = bottomFace[0, 1];

            bottomFace[0, 1] = bottomFace[1, 0];
            bottomFace[1, 0] = bottomFace[2, 1];
            bottomFace[2, 1] = bottomFace[1, 2];
            bottomFace[1, 2] = auxFace;

            auxFace = leftFace[2, 0];

            leftFace[2, 0] = backFace[2, 0];
            backFace[2, 0] = rightFace[2, 0];
            rightFace[2, 0] = frontFace[2, 0];
            frontFace[2, 0] = auxFace;

            auxFace = leftFace[2, 1];

            leftFace[2, 1] = backFace[2, 1];
            backFace[2, 1] = rightFace[2, 1];
            rightFace[2, 1] = frontFace[2, 1];
            frontFace[2, 1] = auxFace;

            auxFace = leftFace[2, 2];

            leftFace[2, 2] = backFace[2, 2];
            backFace[2, 2] = rightFace[2, 2];
            rightFace[2, 2] = frontFace[2, 2];
            frontFace[2, 2] = auxFace;

        }
        private void rotateDp()
        {
            rotateD();
            rotateD();
            rotateD();
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

            ECubes[2] = rightCubes[3];
            ECubes[4] = rightCubes[4];
            ECubes[7] = rightCubes[5];

            string auxFace = rightFace[0, 0];

            rightFace[0, 0] = rightFace[2, 0];
            rightFace[2, 0] = rightFace[2, 2];
            rightFace[2, 2] = rightFace[0, 2];
            rightFace[0, 2] = auxFace;

            auxFace = rightFace[0, 1];

            rightFace[0, 1] = rightFace[1, 0];
            rightFace[1, 0] = rightFace[2, 1];
            rightFace[2, 1] = rightFace[1, 2];
            rightFace[1, 2] = auxFace;

            auxFace = topFace[0, 2];

            topFace[0, 2] = frontFace[0, 2];
            frontFace[0, 2] = bottomFace[0, 2];
            bottomFace[0, 2] = backFace[2, 0];
            backFace[2, 0] = auxFace;

            auxFace = topFace[1, 2];

            topFace[1, 2] = frontFace[1, 2];
            frontFace[1, 2] = bottomFace[1, 2];
            bottomFace[1, 2] = backFace[1, 0];
            backFace[1, 0] = auxFace;

            auxFace = topFace[2, 2];

            topFace[2, 2] = frontFace[2, 2];
            frontFace[2, 2] = bottomFace[2, 2];
            bottomFace[2, 2] = backFace[0, 0];
            backFace[0, 0] = auxFace;
        }
        private void rotateRp()
        {
            rotateR();
            rotateR();
            rotateR();
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

            ECubes[0] = leftCubes[3];
            ECubes[3] = leftCubes[4];
            ECubes[5] = leftCubes[5];

            string auxFace = leftFace[0, 0];

            leftFace[0, 0] = leftFace[2, 0];
            leftFace[2, 0] = leftFace[2, 2];
            leftFace[2, 2] = leftFace[0, 2];
            leftFace[0, 2] = auxFace;

            auxFace = leftFace[0, 1];

            leftFace[0, 1] = leftFace[1, 0];
            leftFace[1, 0] = leftFace[2, 1];
            leftFace[2, 1] = leftFace[1, 2];
            leftFace[1, 2] = auxFace;

            auxFace = topFace[0, 0];

            topFace[0, 0] = backFace[2, 2];
            backFace[2, 2] = bottomFace[0, 0];
            bottomFace[0, 0] = frontFace[0, 0];
            frontFace[0, 0] = auxFace;

            auxFace = topFace[1, 0];

            topFace[1, 0] = backFace[1, 2];
            backFace[1, 2] = bottomFace[1, 0];
            bottomFace[1, 0] = frontFace[1, 0];
            frontFace[1, 0] = auxFace;

            auxFace = topFace[2, 0];

            topFace[2, 0] = backFace[0, 2];
            backFace[0, 2] = bottomFace[2, 0];
            bottomFace[2, 0] = frontFace[2, 0];
            frontFace[2, 0] = auxFace;

        }
        private void rotateLp()
        {
            rotateL();
            rotateL();
            rotateL();
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
            MCubes[7] = frontCubes[7];

            ECubes[5] = frontCubes[3];
            ECubes[6] = frontCubes[4];
            ECubes[7] = frontCubes[5];

            string auxFace = frontFace[0, 0];

            frontFace[0, 0] = frontFace[2, 0];
            frontFace[2, 0] = frontFace[2, 2];
            frontFace[2, 2] = frontFace[0, 2];
            frontFace[0, 2] = auxFace;

            auxFace = frontFace[0, 1];

            frontFace[0, 1] = frontFace[1, 0];
            frontFace[1, 0] = frontFace[2, 1];
            frontFace[2, 1] = frontFace[1, 2];
            frontFace[1, 2] = auxFace;

            auxFace = leftFace[0, 2];

            leftFace[0, 2] = bottomFace[0, 0];
            bottomFace[0, 0] = rightFace[2, 0];
            rightFace[2, 0] = topFace[2, 2];
            topFace[2, 2] = auxFace;

            auxFace = leftFace[1, 2];

            leftFace[1, 2] = bottomFace[0, 1];
            bottomFace[0, 1] = rightFace[1, 0];
            rightFace[1, 0] = topFace[2, 1];
            topFace[2, 1] = auxFace;

            auxFace = leftFace[2, 2];

            leftFace[2, 2] = bottomFace[0, 2];
            bottomFace[0, 2] = rightFace[0, 0];
            rightFace[0, 0] = topFace[2, 0];
            topFace[2, 0] = auxFace;

        }
        private void rotateFp()
        {

            rotateF();
            rotateF();
            rotateF();
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

            ECubes[0] = backCubes[3];
            ECubes[1] = backCubes[4];
            ECubes[2] = backCubes[5];

            string auxFace = backFace[0, 0];

            backFace[0, 0] = backFace[2, 0];
            backFace[2, 0] = backFace[2, 2];
            backFace[2, 2] = backFace[0, 2];
            backFace[0, 2] = auxFace;

            auxFace = backFace[0, 1];

            backFace[0, 1] = backFace[1, 0];
            backFace[1, 0] = backFace[2, 1];
            backFace[2, 1] = backFace[1, 2];
            backFace[1, 2] = auxFace;

            auxFace = leftFace[2, 0];

            leftFace[2, 0] = topFace[0, 0];
            topFace[0, 0] = rightFace[0, 2];
            rightFace[0, 2] = bottomFace[2, 2];
            bottomFace[2, 2] = auxFace;

            auxFace = leftFace[1, 0];

            leftFace[1, 0] = topFace[0, 1];
            topFace[0, 1] = rightFace[1, 2];
            rightFace[1, 2] = bottomFace[2, 1];
            bottomFace[2, 1] = auxFace;

            auxFace = leftFace[0, 0];

            leftFace[0, 0] = topFace[0, 2];
            topFace[0, 2] = rightFace[2, 2];
            rightFace[2, 2] = bottomFace[2, 0];
            bottomFace[2, 0] = auxFace;

        }
        private void rotateBp()
        {

            rotateB();
            rotateB();
            rotateB();
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
            leftCubes[7] = SCubes[5];

            MCubes[1] = SCubes[1];
            MCubes[6] = SCubes[6];

            ECubes[3] = SCubes[3];
            ECubes[4] = SCubes[4];

            string auxFace = topFace[1,0];

            topFace[1,0] = leftFace[2,1];
            leftFace[2,1] = bottomFace[1,2];
            bottomFace[1,2] = rightFace[0,1];
            rightFace[0,1] = auxFace;

            auxFace = topFace[1, 1];

            topFace[1, 1] = leftFace[1, 1];
            leftFace[1, 1] = bottomFace[1, 1];
            bottomFace[1, 1] = rightFace[1, 1];
            rightFace[1, 1] = auxFace;

            auxFace = topFace[1, 2];

            topFace[1, 2] = leftFace[0, 1];
            leftFace[0, 1] = bottomFace[1, 0];
            bottomFace[1, 0] = rightFace[2, 1];
            rightFace[2, 1] = auxFace;

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

            SCubes[1] = MCubes[1];
            SCubes[6] = MCubes[6];

            ECubes[1] = MCubes[3];
            ECubes[6] = MCubes[4];

            string auxFace = topFace[0, 1];

            topFace[0, 1] = backFace[2, 1];
            backFace[2, 1] = bottomFace[0, 1];
            bottomFace[0, 1] = frontFace[0, 1];
            frontFace[0, 1] = auxFace;

            auxFace = topFace[1, 1];

            topFace[1, 1] = backFace[1, 1];
            backFace[1, 1] = bottomFace[1, 1];
            bottomFace[1, 1] = frontFace[1, 1];
            frontFace[1, 1] = auxFace;

            auxFace = topFace[2, 1];

            topFace[2, 1] = backFace[0, 1];
            backFace[0, 1] = bottomFace[2, 1];
            bottomFace[2, 1] = frontFace[2, 1];
            frontFace[2, 1] = auxFace;
        }
        private void rotateE()
        {
            Cube aux = ECubes[0];

            ECubes[0] = ECubes[2];
            ECubes[2] = ECubes[7];
            ECubes[7] = ECubes[5];
            ECubes[5] = aux;
            aux = ECubes[1];
            ECubes[1] = ECubes[4];
            ECubes[4] = ECubes[6];
            ECubes[6] = ECubes[3];
            ECubes[3] = aux;

            leftCubes[3] = ECubes[0];
            leftCubes[4] = ECubes[3];
            leftCubes[5] = ECubes[5];

            backCubes[3] = ECubes[0];
            backCubes[4] = ECubes[1];
            backCubes[5] = ECubes[2];

            frontCubes[3] = ECubes[5];
            frontCubes[4] = ECubes[6];
            frontCubes[5] = ECubes[7];

            rightCubes[3] = ECubes[2];
            rightCubes[4] = ECubes[4];
            rightCubes[5] = ECubes[7];

            MCubes[3] = ECubes[1];
            MCubes[4] = ECubes[6];

            SCubes[3] = ECubes[3];
            SCubes[4] = ECubes[4];

            string auxFace = leftFace[1, 0];

            leftFace[1, 0] = backFace[1, 0];
            backFace[1, 0] = rightFace[1, 0];
            rightFace[1, 0] = frontFace[1, 0];
            frontFace[1, 0] = auxFace;

            auxFace = leftFace[1, 1];

            leftFace[1, 1] = backFace[1, 1];
            backFace[1, 1] = rightFace[1, 1];
            rightFace[1, 1] = frontFace[1, 1];
            frontFace[1, 1] = auxFace;

            auxFace = leftFace[1, 2];

            leftFace[1, 2] = backFace[1, 2];
            backFace[1, 2] = rightFace[1, 2];
            rightFace[1, 2] = frontFace[1, 2];
            frontFace[1, 2] = auxFace;
        }
        private void rotateEp()
        {

            rotateE();
            rotateE();
            rotateE();
        }
        private void rotateSp()
        {

            rotateS();
            rotateS();
            rotateS();
        }
        private void rotateMp()
        {
            rotateM();
            rotateM();
            rotateM();
        }
        private void rotateX()
        {            
            rotateMp();
            rotateR();
            rotateLp();
        }
        private void rotateY()
        {
            rotateEp();
            rotateU();
            rotateDp();
        }
        private void rotateZ()
        {
            rotateBp();
            rotateS();
            rotateF();
        }
        private void rotateXp()
        {
            rotateX();
            rotateX();
            rotateX();
        }
        private void rotateYp()
        {
            rotateY();
            rotateY();
            rotateY();
        }
        private void rotateZp()
        {
            rotateZ();
            rotateZ();
            rotateZ();
        }
        #endregion

        #region move clicks
        private void FWmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Fw();
            btnSwitch(true);          
        }
        private void BWmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Bw();
            btnSwitch(true);
        }
        private void LWmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Lw();
            btnSwitch(true);
        }
        private void DWmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Dw();
            btnSwitch(true);
        }
        private void UWmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Uw();
            btnSwitch(true);
        }
        private void BWpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Bwp();
            btnSwitch(true);
        }
        private void FWpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Fwp();
            btnSwitch(true);
        }
        private void RWpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Rwp();
            btnSwitch(true);
        }
        private void DWpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Dwp();
            btnSwitch(true);
        }
        private void UWpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Uwp();
            btnSwitch(true);
        }
        private void LWpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Lwp();
            btnSwitch(true);
        }
        private void RWmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Rw();
            btnSwitch(true);
        }
        private void Smove_Click(object sender, EventArgs em)
        {
            btnSwitch(false);
            S();
            btnSwitch(true);
        }
        private void BpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Bp();
            btnSwitch(true);
        }
        private void Bmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            B();
            btnSwitch(true);
        }
        private void LpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Lp();
            btnSwitch(true);
        }
        private void Lmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            L();
            btnSwitch(true);
        }
        private void Umove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            U();
            btnSwitch(true);
        }
        private void UpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Up();
            btnSwitch(true);
        }
        private void Dmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            D();
            btnSwitch(true);
        }
        private void DpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Dp();
            btnSwitch(true);
        }
        private void Rmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            R();
            btnSwitch(true);
        }
        private void Fmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            F();
            btnSwitch(true);
        }
        private void RpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Rp();
            btnSwitch(true);
        }
        private void FpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Fp();
            btnSwitch(true);
        }
        private void Xmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            X();
            btnSwitch(true);
        }
        private void Zmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Z();
            btnSwitch(true);
        }
        private void Ymove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Y();
            btnSwitch(true);
        }
        private void L2_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            L2();
            btnSwitch(true);
        }
        private void SpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Sp();
            btnSwitch(true);
        }
        private void EpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Ep();
            btnSwitch(true);
        }
        private void MpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Mp();
            btnSwitch(true);
        }
        private void U2_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            U2();
            btnSwitch(true);
        }
        private void Emove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            E();
            btnSwitch(true);
        }
        private void F2_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            F2();
            btnSwitch(true);
        }
        private void B2_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            B2();
            btnSwitch(true);
        }
        private void D2_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            D2();
            btnSwitch(true);
        }
        private void R2_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            R2();
            btnSwitch(true);
        }
        private void YpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Yp();
            btnSwitch(true);
        }
        private void ZpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Zp();
            btnSwitch(true);
        }
        private void XpMove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            Xp();
            btnSwitch(true);
        }
        private void Mmove_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            M();
            btnSwitch(true);
        }
        #endregion

        #region move timers
        private void UwMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateU();
                rotateEp();
                angle90 = 0;
                UwMoveTimer.Stop();
            }
        }
        private void BwMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in backCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateB();
                rotateSp();
                angle90 = 0;
                BwMoveTimer.Stop();
            }
        }
        private void RwpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateRp();
                rotateM();
                angle90 = 0;
                RwpMoveTimer.Stop();
            }
        }
        private void FwpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in frontCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateFp();
                rotateSp();
                angle90 = 0;
                FwpMoveTimer.Stop();
            }
        }
        private void LwpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in leftCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateLp();
                rotateMp();
                angle90 = 0;
                LwpMoveTimer.Stop();
            }
        }
        private void UwpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateUp();
                rotateE();
                angle90 = 0;
                UwpMoveTimer.Stop();
            }
        }
        private void DwMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateD();
                rotateE();
                angle90 = 0;
                DwMoveTimer.Stop();
            }
        }
        private void BwpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in backCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateBp();
                rotateS();
                angle90 = 0;
                BwpMoveTimer.Stop();
            }
        }
        private void RwMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateR();
                rotateMp();
                angle90 = 0;
                RwMoveTimer.Stop();
            }
        }
        private void FwMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in frontCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateF();
                rotateS();
                angle90 = 0;
                FwMoveTimer.Stop();
            }
        }
        private void LwMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in leftCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateL();
                rotateM();
                angle90 = 0;
                LwMoveTimer.Stop();
            }
        }
        private void DwpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateDp();
                rotateEp();
                angle90 = 0;
                DwpMoveTimer.Stop();
            }
        }
        private void MmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateM();
                angle90 = 0;
                MmoveTimer.Stop();
            }
        }
        private void EmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateE();
                angle90 = 0;
                EmoveTimer.Stop();
            }
        }
        private void SpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateSp();
                angle90 = 0;
                SpMoveTimer.Stop();
            }
        }
        private void MpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in MCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateMp();
                angle90 = 0;
                MpMoveTimer.Stop();
            }
        }
        private void EpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in ECubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateEp();
                angle90 = 0;
                EpMoveTimer.Stop();
            }
        }
        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateUp();
                angle90 = 0;
                UpMoveTimer.Stop();
            }
        }
        private void UmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in topCubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateU();
                angle90 = 0;
                UmoveTimer.Stop();
            }
        }
        private void DmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateD();
                angle90 = 0;
                DmoveTimer.Stop();
            }
        }
        private void DpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in bottomCubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateDp();
                angle90 = 0;
                DpMoveTimer.Stop();
            }
        }
        private void RmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateR();
                angle90 = 0;
                RmoveTimer.Stop();
            }
        }
        private void RpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in rightCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateRp();
                angle90 = 0;
                RpMoveTimer.Stop();
            }
        }
        private void FmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in frontCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateF();
                angle90 = 0;
                FmoveTimer.Stop();
            }
        }
        private void FpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in frontCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateFp();
                angle90 = 0;
                FpMoveTimer.Stop();
            }
        }
        private void XmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateX();
                angle90 = 0;
                XmoveTimer.Stop();
            }
        }
        private void YmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateY();
                angle90 = 0;
                YmoveTimer.Stop();
            }
        }
        private void ZmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateZ();
                angle90 = 0;
                ZmoveTimer.Stop();
            }
        }
        private void LmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in leftCubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateL();
                angle90 = 0;
                LmoveTimer.Stop();
            }
        }
        private void XpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeX(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateXp();
                angle90 = 00;
                XpMoveTimer.Stop();
            }
        }
        private void YpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeY(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateYp();
                angle90 = 0;
                YpMoveTimer.Stop();
            }
        }
        private void ZpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in cubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateZp();
                angle90 = 0;
                ZpMoveTimer.Stop();
            }
        }
        private void LpMovetimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in leftCubes)
            {
                cube.RotateCubeX(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateLp();
                angle90 = 0;
                LpMoveTimer.Stop();
            }
        }
        private void BmoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in backCubes)
            {
                cube.RotateCubeZ(-frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateB();
                angle90 = 0;
                BmoveTimer.Stop();
            }
        }
        private void BpMoveTimer_Tick(object sender, EventArgs e)
        {
            timerFirstHalf();
            foreach (Cube cube in backCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateBp();
                angle90 = 0;
                BpMoveTimer.Stop();
            }
        }
        private void SmoveTimer_Tick(object sender, EventArgs e)
        {

            timerFirstHalf();
            foreach (Cube cube in SCubes)
            {
                cube.RotateCubeZ(frameAngle);
            }
            timerSecondHalf();
            angle90 += frameAngle;
            if (angle90 == 90)
            {
                rotateS();
                angle90 = 0;
                SmoveTimer.Stop();
            }

        }
        #endregion

        #region moves
        private void U()
        {
            UmoveTimer.Start();
            wait(waitingTime);
        }
        private void Uw()
        {
            UwMoveTimer.Start();
            wait(waitingTime);
        }
        private void Up()
        {
            UpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Uwp()
        {
            UwpMoveTimer.Start();
            wait(waitingTime);
        }
        private void U2()
        {
            UmoveTimer.Start();
            wait(waitingTime);
            UmoveTimer.Start();
            wait(waitingTime);
        }
        private void L()
        {
            LmoveTimer.Start();
            wait(waitingTime);
        }
        private void Lw()
        {
            LwMoveTimer.Start();
            wait(waitingTime);
        }
        private void Lp()
        {
            LpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Lwp()
        {
            LwpMoveTimer.Start();
            wait(waitingTime);
        }
        private void L2()
        {
            LmoveTimer.Start();
            wait(waitingTime);
            LmoveTimer.Start();
            wait(waitingTime);
        }
        private void F()
        {
            FmoveTimer.Start();
            wait(waitingTime);
        }
        private void Fw()
        {
            FwMoveTimer.Start();
            wait(waitingTime);
        }
        private void Fp()
        {
            FpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Fwp()
        {
            FwpMoveTimer.Start();
            wait(waitingTime);
        }
        private void F2()
        {
            FmoveTimer.Start();
            wait(waitingTime);
            FmoveTimer.Start();
            wait(waitingTime);
        }
        private void R()
        {
            RmoveTimer.Start();
            wait(waitingTime);
        }
        private void Rw()
        {
            RwMoveTimer.Start();
            wait(waitingTime);
        }
        private void Rp()
        {
            RpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Rwp()
        {
            RwpMoveTimer.Start();
            wait(waitingTime);
        }
        private void R2()
        {
            RmoveTimer.Start();
            wait(waitingTime);
            RmoveTimer.Start();
            wait(waitingTime);
        }
        private void X()
        {
            XmoveTimer.Start();
            wait(waitingTime);
        }
        private void Y()
        {
            YmoveTimer.Start();
            wait(waitingTime);
        }
        private void Z()
        {
            ZmoveTimer.Start();
            wait(waitingTime);
        }
        private void Xp()
        {
            XpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Yp()
        {
            YpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Zp()
        {
            ZpMoveTimer.Start();
            wait(waitingTime);
        }
        private void B()
        {
            BmoveTimer.Start();
            wait(waitingTime);
        }
        private void Bw()
        {
            BwMoveTimer.Start();
            wait(waitingTime);
        }
        private void Bp()
        {
            BpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Bwp()
        {
            BwpMoveTimer.Start();
            wait(waitingTime);
        }
        private void B2()
        {
            BmoveTimer.Start();
            wait(waitingTime);
            BmoveTimer.Start();
            wait(waitingTime);
        }
        private void D()
        {
            DmoveTimer.Start();
            wait(waitingTime);
        }
        private void Dw()
        {
            DwMoveTimer.Start();
            wait(waitingTime);
        }
        private void Dp()
        {
            DpMoveTimer.Start();
            wait(waitingTime);
        }
        private void Dwp()
        {
            DwpMoveTimer.Start();
            wait(waitingTime);
        }
        private void D2()
        {
            DmoveTimer.Start();
            wait(waitingTime);
            DmoveTimer.Start();
            wait(waitingTime);
        }
        private void M()
        {
            MmoveTimer.Start();
            wait(waitingTime);
        }
        private void Mp()
        {
            MpMoveTimer.Start();
            wait(waitingTime);
        }
        private void M2()
        {
            MmoveTimer.Start();
            wait(waitingTime);
            MmoveTimer.Start();
            wait(waitingTime);
        }
        private void E()
        {
            EmoveTimer.Start();
            wait(waitingTime);
        }
        private void Ep()
        {
            EpMoveTimer.Start();
            wait(waitingTime);
        }
        private void E2()
        {
            EmoveTimer.Start();
            wait(waitingTime);
            EmoveTimer.Start();
            wait(waitingTime);
        }
        private void S()
        {
            SmoveTimer.Start();
            wait(waitingTime);
        }
        private void Sp()
        {
            SpMoveTimer.Start();
            wait(waitingTime);
        }
        private void S2()
        {
            SmoveTimer.Start();
            wait(waitingTime);
            SmoveTimer.Start();
            wait(waitingTime);
        }
        #endregion

        public void btnSwitch(bool Switch)
        {
            foreach (Control ctrl in Controls)
            {
                Button btn = ctrl as Button;
                if (btn != null)
                {
                    btn.Enabled = Switch;
                }
            }
        }

        public bool isCubeHalfSolved()
        {
            bool ok = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        if (topFace[i, j] != whiteFace[i, j])
                        {
                            ok = false;
                        }
                        if (leftFace[i, j] != orangeFace[i, j])
                        {
                            ok = false;
                        }
                        if (frontFace[i, j] != greenFace[i, j])
                        {
                            ok = false;
                        }
                        if (rightFace[i, j] != redFace[i, j])
                        {
                            ok = false;
                        }
                        if (backFace[i, j] != blueFace[i, j])
                        {
                            ok = false;
                        }
                        if (bottomFace[i, j] != yellowFace[i, j])
                        {
                            ok = false;
                        }
                    }
                }
            }
            return ok;
        }
        public bool isCubeSolved()
        {
            bool ok = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (topFace[i, j] != whiteFace[i, j])
                    {
                        ok = false;
                    }
                    if (leftFace[i, j] != orangeFace[i, j])
                    {
                        ok = false;
                    }
                    if (frontFace[i, j] != greenFace[i, j])
                    {
                        ok = false;
                    }
                    if (rightFace[i, j] != redFace[i, j])
                    {
                        ok = false;
                    }
                    if (backFace[i, j] != blueFace[i, j])
                    {
                        ok = false;
                    }
                    if (bottomFace[i, j] != yellowFace[i, j])
                    {
                        ok = false;
                    }

                }
            }
            return ok;
        }

        #region scramble/solve clicks
        private void Scramble_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            scramble();
            btnSwitch(true);
        }
        private void solveButton_Click(object sender, EventArgs e)
        {
            btnSwitch(false);
            int moveCounter = 0;
            bool ok;            
            while (frontFace[1, 1] != "2")
            {
                X();
                if (frontFace[1, 1] != "2")
                {
                    Y();
                }
            }
            while (topFace[1, 1] != "0")
            {
                Z();
            }
            solveLabel.Text = "Edges Solution:";
            solveLabel2.Text = "Corners Solution:";
            ok = isCubeHalfSolved();            
            while (!ok)
            {
                solve(topFace[1, 2]);
                moveCounter++;
                ok = isCubeHalfSolved();                
            }
            if (moveCounter % 2 != 0)
            {
                Rperm();
                solveLabel.Text += " Ra";
            }
            ok = isCubeSolved();
            while (!ok)
            {
                solve(leftFace[0, 0]);
                ok = isCubeSolved();                
            }
            btnSwitch(true);
        }
        private void fastSolveButton_Click(object sender, EventArgs e)
        {
            frameAngle = 90;
            waitingTime = 1;
            turningSpeed = 1;
            solveButton_Click(sender, e);
            frameAngle = 10;
            waitingTime = 200;
            turningSpeed = 1;
        }
        #endregion

        #region scramble/solve methods
        private void scramble()
        {
            fastSolveButton_Click(new object(), new EventArgs());

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
            scrambleLabel.Visible = true;
            scrambleLabel.Text = scrambleOutput;
            scrambleOutput = "";

        }
        private void solve(string bumper)
        {
            string exception;
            switch (bumper)
            {
                case "Ac":
                    exception = "exception";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if ((i + j) % 2 == 0 && (i != 1 && j != 1))
                            {
                                if (topFace[i, j] != whiteFace[i, j] && (i != 0 && j != 0))
                                {
                                    exception = topFace[i, j];
                                }
                                else
                                if (leftFace[i, j] != orangeFace[i, j] && (i != 0 && j != 0))
                                {
                                    exception = leftFace[i, j];
                                }
                                else
                                if (frontFace[i, j] != greenFace[i, j])
                                {
                                    exception = frontFace[i, j];
                                }
                                else
                                if (rightFace[i, j] != redFace[i, j])
                                {
                                    exception = rightFace[i, j];
                                }
                                else
                                if (backFace[i, j] != blueFace[i, j] && (i != 0 && j != 2))
                                {
                                    exception = backFace[i, j];
                                }
                                else
                                if (bottomFace[i, j] != yellowFace[i, j])
                                {
                                    exception = bottomFace[i, j];
                                }
                            }
                        }
                    }
                    solve(exception);
                    break;

                case "As":
                    M2();
                    Dp();
                    L2();
                    Tperm();
                    L2();
                    D();
                    M2();
                    solveLabel.Text += " A";
                    break;

                case "Bc":
                    R2();
                    Yperm();
                    R2();
                    solveLabel2.Text += " B";
                    break;

                case "Bs":
                    exception = "exception";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if ((i + j) % 2 != 0)
                            {
                                if (topFace[i, j] != whiteFace[i, j])
                                {
                                    exception = topFace[i, j];
                                }
                                else
                                if (leftFace[i, j] != orangeFace[i, j])
                                {
                                    exception = leftFace[i, j];
                                }
                                else
                                if (frontFace[i, j] != greenFace[i, j])
                                {
                                    exception = frontFace[i, j];
                                }
                                else
                                if (rightFace[i, j] != redFace[i, j])
                                {
                                    exception = rightFace[i, j];
                                }
                                else
                                if (backFace[i, j] != blueFace[i, j])
                                {
                                    exception = backFace[i, j];
                                }
                                else
                                if (bottomFace[i, j] != yellowFace[i, j])
                                {
                                    exception = bottomFace[i, j];
                                }
                            }
                        }
                    }
                    solve(exception);
                    break;

                case "Cc":
                    R2();
                    Dp();
                    Yperm();
                    D();
                    R2();
                    solveLabel2.Text += " C";
                    break;

                case "Cs":
                    M2();
                    D();
                    L2();
                    Tperm();
                    L2();
                    Dp();
                    M2();
                    solveLabel.Text += " C";
                    break;

                case "Dc":
                    F2();
                    Yperm();
                    F2();
                    solveLabel2.Text += " D";
                    break;

                case "Ds":
                    Tperm();
                    solveLabel.Text += " D";
                    break;

                case "Ec":
                    exception = "exception";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if ((i + j) % 2 == 0 && (i != 1 && j != 1))
                            {
                                if (topFace[i, j] != whiteFace[i, j] && (i != 0 && j != 0))
                                {
                                    exception = topFace[i, j];
                                }
                                else
                                if (leftFace[i, j] != orangeFace[i, j] && (i != 0 && j != 0))
                                {
                                    exception = leftFace[i, j];
                                }
                                else
                                if (frontFace[i, j] != greenFace[i, j])
                                {
                                    exception = frontFace[i, j];
                                }
                                else
                                if (rightFace[i, j] != redFace[i, j])
                                {
                                    exception = rightFace[i, j];
                                }
                                else
                                if (backFace[i, j] != blueFace[i, j] && (i != 0 && j != 2))
                                {
                                    exception = backFace[i, j];
                                }
                                else
                                if (bottomFace[i, j] != yellowFace[i, j])
                                {
                                    exception = bottomFace[i, j];
                                }
                            }
                        }
                    }
                    solve(exception);
                    break;

                case "Es":
                    Lp();
                    E();
                    Lp();
                    Tperm();
                    L();
                    Ep();
                    L();
                    solveLabel.Text += " E";
                    break;

                case "Fc":
                    Fp();
                    D();
                    Yperm();
                    Dp();
                    F();
                    solveLabel2.Text += " F";
                    break;

                case "Fs":
                    Ep();
                    L();
                    Tperm();
                    Lp();
                    E();
                    solveLabel.Text += " F";
                    break;

                case "Gc":
                    Fp();
                    Yperm();
                    F();
                    solveLabel2.Text += " G";
                    break;

                case "Gs":
                    L();
                    E();
                    Lp();
                    Tperm();
                    L();
                    Ep();
                    Lp();
                    solveLabel.Text += " G";
                    break;

                case "Hc":
                    Dp();
                    R();
                    Yperm();
                    Rp();
                    D();
                    solveLabel2.Text += " H";
                    break;


                case "Hs":
                    E();
                    Lp();
                    Tperm();
                    L();
                    Ep();
                    solveLabel.Text += " H";
                    break;

                case "Ic":
                    F();
                    Rp();
                    Yperm();
                    R();
                    Fp();
                    solveLabel2.Text += " I";
                    break;

                case "Is":
                    M();
                    Dp();
                    L2();
                    Tperm();
                    L2();
                    D();
                    Mp();
                    solveLabel.Text += " I";
                    break;

                case "Jc":
                    Rp();
                    Yperm();
                    R();
                    solveLabel2.Text += " J";
                    break;

                case "Js":
                    E2();
                    L();
                    Tperm();
                    Lp();
                    E2();
                    solveLabel.Text += " J";
                    break;

                case "Kc":
                    Rp();
                    Dp();
                    Yperm();
                    D();
                    R();
                    solveLabel2.Text += " K";
                    break;

                case "Ks":
                    M();
                    D();
                    L2();
                    Tperm();
                    L2();
                    Dp();
                    Mp();
                    solveLabel.Text += " K";
                    break;

                case "Lc":
                    F2();
                    Rp();
                    Yperm();
                    R();
                    F2();
                    solveLabel2.Text += " L";
                    break;

                case "Ls":
                    Lp();
                    Tperm();
                    L();
                    solveLabel.Text += " L";
                    break;

                case "Mc":
                    F();
                    Yperm();
                    Fp();
                    solveLabel2.Text += " M";
                    break;

                case "Ms":
                    exception = "exception";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if ((i + j) % 2 != 0)
                            {
                                if (topFace[i, j] != whiteFace[i, j])
                                {
                                    if (topFace[i, j] != topFace[1, 2])
                                        exception = topFace[i, j];
                                }
                                else
                                if (leftFace[i, j] != orangeFace[i, j])
                                {
                                    exception = leftFace[i, j];

                                }
                                else
                                if (frontFace[i, j] != greenFace[i, j])
                                {
                                    exception = frontFace[i, j];

                                }
                                else
                                if (rightFace[i, j] != redFace[i, j])
                                {
                                    exception = rightFace[i, j];
                                }
                                else
                                if (backFace[i, j] != blueFace[i, j])
                                {
                                    exception = backFace[i, j];

                                }
                                else
                                if (bottomFace[i, j] != yellowFace[i, j])
                                {
                                    exception = bottomFace[i, j];

                                }
                            }
                        }
                    }
                    solve(exception);
                    break;

                case "Nc":
                    Rp();
                    F();
                    Yperm();
                    Fp();
                    R();
                    solveLabel2.Text += " N";
                    break;

                case "Ns":
                    E();
                    L();
                    Tperm();
                    Lp();
                    Ep();
                    solveLabel.Text += " N";
                    break;

                case "Oc":
                    R2();
                    F();
                    Yperm();
                    Fp();
                    R2();
                    solveLabel2.Text += " O";
                    break;

                case "Os":
                    Dp();
                    M();
                    D();
                    L2();
                    Tperm();
                    L2();
                    Dp();
                    Mp();
                    D();
                    solveLabel.Text += " O";
                    break;

                case "Pc":
                    R();
                    F();
                    Yperm();
                    Fp();
                    Rp();
                    solveLabel2.Text += " P";
                    break;

                case "Ps":
                    Ep();
                    Lp();
                    Tperm();
                    L();
                    E();
                    solveLabel.Text += " P";
                    break;

                case "Qc":
                    R();
                    Dp();
                    Yperm();
                    D();
                    Rp();
                    solveLabel2.Text += " Q";
                    break;

                case "Qs":
                    Mp();
                    D();
                    L2();
                    Tperm();
                    L2();
                    Dp();
                    M();
                    solveLabel.Text += " Q";
                    break;

                case "Rc":
                    exception = "exception";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if ((i + j) % 2 == 0 && (i != 1 && j != 1))
                            {
                                if (topFace[i, j] != whiteFace[i, j] && (i != 0 && j != 0))
                                {
                                    exception = topFace[i, j];
                                }
                                else
                                if (leftFace[i, j] != orangeFace[i, j] && (i != 0 && j != 0))
                                {
                                    exception = leftFace[i, j];

                                }
                                else
                                if (frontFace[i, j] != greenFace[i, j])
                                {
                                    exception = frontFace[i, j];

                                }
                                else
                                if (rightFace[i, j] != redFace[i, j])
                                {
                                    exception = rightFace[i, j];
                                }
                                else
                                if (backFace[i, j] != blueFace[i, j] && (i != 0 && j != 2))
                                {
                                    exception = backFace[i, j];

                                }
                                else
                                if (bottomFace[i, j] != yellowFace[i, j])
                                {
                                    exception = bottomFace[i, j];

                                }
                            }
                        }
                    }
                    solve(exception);
                    break;

                case "Rs":
                    L();
                    Tperm();
                    Lp();
                    solveLabel.Text += " R";
                    break;

                case "Sc":
                    D();
                    Fp();
                    Yperm();
                    F();
                    Dp();
                    solveLabel2.Text += " S";
                    break;

                case "Ss":
                    Mp();
                    Dp();
                    L2();
                    Tperm();
                    L2();
                    D();
                    M();
                    solveLabel.Text += " S";
                    break;

                case "Tc":
                    R();
                    Yperm();
                    Rp();
                    solveLabel2.Text += " T";
                    break;

                case "Ts":
                    E2();
                    Lp();
                    Tperm();
                    L();
                    E2();
                    solveLabel.Text += " T";
                    break;

                case "Uc":
                    D();
                    Yperm();
                    Dp();
                    solveLabel2.Text += " U";
                    break;

                case "Us":
                    Dp();
                    L2();
                    Tperm();
                    L2();
                    D();
                    solveLabel.Text += " U";
                    break;

                case "Vc":
                    Yperm();
                    solveLabel2.Text += " V";
                    break;

                case "Vs":
                    D2();
                    L2();
                    Tperm();
                    L2();
                    D2();
                    solveLabel.Text += " V";
                    break;

                case "Wc":
                    Dp();
                    Yperm();
                    D();
                    solveLabel2.Text += " W";
                    break;

                case "Ws":
                    D();
                    L2();
                    Tperm();
                    L2();
                    Dp();
                    solveLabel.Text += " W";
                    break;


                case "Xc":
                    D2();
                    Yperm();
                    D2();
                    solveLabel2.Text += " X";
                    break;

                case "Xs":
                    L2();
                    Tperm();
                    L2();
                    solveLabel.Text += " X";
                    break;
            }
        }

        #endregion

        private void randomRLMove(int randomNumber)
        {

            switch (randomNumber)
            {
                case 0:
                    L();
                    scrambleOutput += " L";
                    break;
                case 1:
                    Lp();
                    scrambleOutput += " L'";
                    break;
                case 2:
                    R();
                    scrambleOutput += " R";
                    break;
                case 3:
                    Rp();
                    scrambleOutput += " R'";
                    break;
                case 4:
                    R2();                    
                    scrambleOutput += " R2";
                    break;
                case 5:
                    L2();
                    scrambleOutput += " L2";
                    break;
            }
        }
        private void randomUDMove(int randomNumber)
        {

            switch (randomNumber)
            {

                case 0:
                    U();
                    scrambleOutput += " U";
                    break;
                case 1:
                    Up();
                    scrambleOutput += " U'";
                    break;
                case 2:
                    D();
                    scrambleOutput += " D";
                    break;
                case 3:
                    Dp();
                    scrambleOutput += " D'";
                    break;
                case 4:
                    U2();
                    scrambleOutput += " U2";
                    break;
                case 5:
                    D2();                  
                    scrambleOutput += " D2";
                    break;
            }
        }
        private void randomFBMove(int randomNumber)
        {

            switch (randomNumber)
            {
                case 0:
                    B();                   
                    scrambleOutput += " B";
                    break;
                case 1:
                    Bp();                    
                    scrambleOutput += " B'";
                    break;
                case 2:
                    F();                    
                    scrambleOutput += " F";
                    break;
                case 3:
                    Fp();
                    scrambleOutput += " F'";
                    break;
                case 4:
                    B2();               
                    scrambleOutput += " B2";
                    break;
                case 5:
                    F2();
                    scrambleOutput += " F2";
                    break;
            }
        }

        #region algs
        private void Tperm()
        {
            /* R U R' U' R' F R2 U' R' U' R U R' F' */
            R();
            U();
            Rp();
            Up();
            Rp();
            F();
            R2();
            Up();
            Rp();
            Up();
            R();
            U();
            Rp();
            Fp();
        }
        private void Rperm()
        {
            //R U' R' U' R U R D R' U' R D' R' U2 R'
            R();
            Up();
            Rp();
            Up();
            R();
            U();
            R();
            D();
            Rp();
            Up();
            R();
            Dp();
            Rp();
            U2();
            Rp();
            Up();
        }
        private void Yperm()
        {
            //R U' R' U' R U R' F' R U R' U' R' F R
            R();
            Up();
            Rp();
            Up();
            R();
            U();
            Rp();
            Fp();
            R();
            U();
            Rp();
            Up();
            Rp();
            F();
            R();           
        }
        #endregion
    }
}
