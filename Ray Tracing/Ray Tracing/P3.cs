using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class P3
    {
        public float x;
        public float y;
        public float z;

        public P3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public P3 add(P3 v)
        {
            return new P3(v.x + this.x, v.y + this.y, v.z + this.z);
        }

        public P3 sub(P3 v)
        {
            return new P3(v.x - this.x, v.y - this.y, v.z - this.z);
        }

        public float normLength(P3 v)
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public static P3 mul(P3 p, P3 p2)
        {
            return new P3(p.x * p2.x, p.y * p2.y, p.z * p2.z);
        }
        public float size()
        {
            return normLength(new P3(0, 0, 0));
        }

        public P3 scale(float scale)
        {
            return new P3(x * scale, y * scale, z * scale);
        }

        public P3 normalize()
        {
            float sizer = size();
            return new P3(x / sizer, y / sizer, z / sizer);

        }

        public float dotProduct(P3 v)
        {
            return x * v.x + y * v.y + z * v.z;
        }

        public static P3 crossProduct(P3 a, P3 b)
        {
            return new P3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        }

        public static P3 fromSpherical(float theta, float phi)
        {
            float x2 = (float)Math.Cos(theta) * (float)Math.Sin(phi);
            float y2 = (float)Math.Sin(theta) * (float)Math.Sin(phi);
            float z2 = (float)Math.Cos(phi);
            return new P3(x2, y2, z2);
        }

    }
}
