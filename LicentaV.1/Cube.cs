using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulator
{
    public class Cube
    {
        static int size = 40;
        public float[] a = { size, size, size };
        public float[] b = { size, -size, size };
        public float[] c = { size, -size, -size };
        public float[] d = { size, size, -size };
        public float[] e = { -size, size, size };
        public float[] f = { -size, -size, size };
        public float[] g = { -size, -size, -size };
        public float[] h = { -size, size, -size };
        public int x;
        public int y;
        public int z;

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.a[0] += x + 100;
            this.b[0] += x + 100;
            this.c[0] += x + 100;
            this.d[0] += x + 100;
            this.e[0] += x + 100;
            this.f[0] += x + 100;
            this.g[0] += x + 100;
            this.h[0] += x + 100;

            this.a[1] += y + 100;
            this.b[1] += y + 100;
            this.c[1] += y + 100;
            this.d[1] += y + 100;
            this.e[1] += y + 100;
            this.f[1] += y + 100;
            this.g[1] += y + 100;
            this.h[1] += y + 100;

            this.a[2] += z + 100;
            this.b[2] += z + 100;
            this.c[2] += z + 100;
            this.d[2] += z + 100;
            this.e[2] += z + 100;
            this.f[2] += z + 100;
            this.g[2] += z + 100;
            this.h[2] += z + 100;
        }
        public void RotatePointX(float[] point, int angle)
        {
            double radian = angle * Math.PI / 180.0;
            float aux1 = point[1] - 100;
            float aux2 = point[2] - 100;
            float[] result = new float[3];

            result[1] = (float)Math.Cos(radian) * aux1 - (float)Math.Sin(radian) * aux2;
            result[2] = (float)Math.Sin(radian) * aux1 + (float)Math.Cos(radian) * aux2;

            result[1] = result[1] + 100;
            result[2] = result[2] + 100;

            point[1] = result[1];
            point[2] = result[2];
        }
        public void RotatePointY(float[] point, int angle)
        {
            double radian = angle * Math.PI / 180.0;
            float aux0 = point[0] - 200;
            float aux2 = point[2] - 200;
            float[] result = new float[3];


            result[0] = (float)Math.Cos(radian) * aux0 + (float)Math.Sin(radian) * aux2;
            result[2] = -(float)Math.Sin(radian) * aux0 + (float)Math.Cos(radian) * aux2;

            result[0] = result[0] + 200;
            result[2] = result[2] + 200;

            point[0] = result[0];
            point[2] = result[2];
        }
        public void RotatePointZ(float[] point, int angle)
        {
            double radian = angle * Math.PI / 180.0;
            float aux0 = point[0] - 200;
            float aux1 = point[1] - 200;
            float[] result = new float[3];

            result[0] = (float)Math.Cos(radian) * aux0 - (float)Math.Sin(radian) * aux1;
            result[1] = (float)Math.Sin(radian) * aux0 + (float)Math.Cos(radian) * aux1;

            result[0] = result[0] + 200;
            result[1] = result[1] + 200;

            point[0] = result[0];
            point[1] = result[1];
        }
        public void RotateCubeX(int angle)
        {
            RotatePointX(a, angle);
            RotatePointX(b, angle);
            RotatePointX(c, angle);
            RotatePointX(d, angle);
            RotatePointX(e, angle);
            RotatePointX(f, angle);
            RotatePointX(g, angle);
            RotatePointX(h, angle);
        }
        public void RotateCubeY(int angle)
        {
            RotatePointY(a, angle);
            RotatePointY(b, angle);
            RotatePointY(c, angle);
            RotatePointY(d, angle);
            RotatePointY(e, angle);
            RotatePointY(f, angle);
            RotatePointY(g, angle);
            RotatePointY(h, angle);
        }
        public void RotateCubeZ(int angle)
        {
            RotatePointZ(a, angle);
            RotatePointZ(b, angle);
            RotatePointZ(c, angle);
            RotatePointZ(d, angle);
            RotatePointZ(e, angle);
            RotatePointZ(f, angle);
            RotatePointZ(g, angle);
            RotatePointZ(h, angle);
        }
        public PointF[] getTop()
        {
           PointF[] top = 
                {
                new PointF(b[0], b[1]),
                new PointF(c[0], c[1]),
                new PointF(g[0], g[1]),
                new PointF(f[0], f[1])
                };
            return top;
        }
        public PointF[] getBottom()
        {
            PointF[] bottom =
                 {
                new PointF(a[0], a[1]),
                new PointF(d[0], d[1]),
                new PointF(h[0], h[1]),
                new PointF(e[0], e[1])
                };
            return bottom;
        }
        public PointF[] getRight()
        {
            PointF[]  right=
                 {
                new PointF(b[0], b[1]),
                new PointF(c[0], c[1]),
                new PointF(d[0], d[1]),
                new PointF(a[0], a[1])
                };
            return right;
        }
        public PointF[] getLeft()
        {
            PointF[] left =
                 {
                new PointF(f[0], f[1]),
                new PointF(g[0], g[1]),
                new PointF(h[0], h[1]),
                new PointF(e[0], e[1])
                };
            return left;
        }
        public PointF[] getBack()
        {
            PointF[] front =
                 {
                new PointF(g[0], g[1]),
                new PointF(c[0], c[1]),
                new PointF(d[0], d[1]),
                new PointF(h[0], h[1])
                };
            return front;
        }
        public PointF[] getFront()
        {
            PointF[] back =
                 {
                new PointF(a[0], a[1]),
                new PointF(b[0], b[1]),
                new PointF(f[0], f[1]),
                new PointF(e[0], e[1])
                };
            return back;
        }
    }
}
