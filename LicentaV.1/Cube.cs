using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaV._1
{
    internal class Cube
    {
        static int size = 20;
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
        private void RotatePointX(float[] point, int angle)
        {
            double radiant = angle * Math.PI / 180.0;
            float aux0 = point[0] - 200;
            float aux1 = point[1] - 200;
            float aux2 = point[2] - 200;
            float[] result = { 1, 2, 3 };
            result[0] = point[0] - 200;
            result[1] = point[1] - 200;
            result[2] = point[2] - 200;

            result[1] = (float)Math.Cos(radiant) * aux1 - (float)Math.Sin(radiant) * aux2;
            result[2] = (float)Math.Sin(radiant) * aux1 + (float)Math.Cos(radiant) * aux2;

            result[0] = result[0] + 200;
            result[1] = result[1] + 200;
            result[2] = result[2] + 200;

            point[0] = result[0];
            point[1] = result[1];
            point[2] = result[2];
        }
        private void RotatePointY(float[] point, int angle)
        {
            double radiant = angle * Math.PI / 180.0;
            float aux0 = point[0] - 200;
            float aux1 = point[1] - 200;
            float aux2 = point[2] - 200;
            float[] result = { 1, 2, 3 };
            result[0] = point[0] - 200;
            result[1] = point[1] - 200;
            result[2] = point[2] - 200;

            result[0] = (float)Math.Cos(radiant) * aux0 + (float)Math.Sin(radiant) * aux2;
            result[2] = -(float)Math.Sin(radiant) * aux0 + (float)Math.Cos(radiant) * aux2;

            result[0] = result[0] + 200;
            result[1] = result[1] + 200;
            result[2] = result[2] + 200;

            point[0] = result[0];
            point[1] = result[1];
            point[2] = result[2];
        }
        private void RotatePointZ(float[] point, int angle)
        {
            double radiant = angle * Math.PI / 180.0;
            float aux0 = point[0] - 200;
            float aux1 = point[1] - 200;
            float aux2 = point[2] - 200;
            float[] result = { 1, 2, 3 };
            result[0] = point[0] - 200;
            result[1] = point[1] - 200;
            result[2] = point[2] - 200;

            result[0] = (float)Math.Cos(radiant) * aux0 - (float)Math.Sin(radiant) * aux1;
            result[1] = (float)Math.Sin(radiant) * aux0 + (float)Math.Cos(radiant) * aux1;

            result[0] = result[0] + 200;
            result[1] = result[1] + 200;
            result[2] = result[2] + 200;

            point[0] = result[0];
            point[1] = result[1];
            point[2] = result[2];
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
            RotatePointY(a, angle);
            RotatePointY(b, angle);
            RotatePointY(c, angle);
            RotatePointY(d, angle);
            RotatePointY(e, angle);
            RotatePointY(f, angle);
            RotatePointY(g, angle);
            RotatePointY(h, angle);
        }       
    }
}
