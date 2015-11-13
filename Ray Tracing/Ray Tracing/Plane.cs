using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class Plane: Geometry
    {
        public P3 n;
        public P3 p;
        public float d;

        public Plane(P3 p, P3 n)
        {
            this.p = p;
            this.n = n;
            this.d = -(n.dotProduct(p));

        }

        public float intersect(Ray r)
        {
            P3 o = r.origin;
            P3 v = r.direction;
            r = new Ray(o, v);
            if (n.dotProduct(v) < 0)
            {
                return -1;
            }
            float t = -(d + n.dotProduct(o)) / (n.dotProduct(v));
            if (t < 0)
            {
                return -1;
            }
            return t;
        }

        public P3 normal(P3 p)
        {
            return n;
        }
        

        public P2 toP2(P3 p)
        {
            return new P2(0, 0);
        }
    }
}
