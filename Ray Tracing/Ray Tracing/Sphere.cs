using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class Sphere: Geometry
    {
        public P3 center;
        public float radius;
        public Ray R;
        public P3 o;
        public P3 EO;
        public P3 e;
        P3 Vn = new P3(0, 0, 1);
        P3 Ve = new P3(1, 0, 0);
        P3 hpr = new P3(0, 0, 0);

        public Sphere(P3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
            
        }
        public P3 normal(P3 p)
        {
            P3 v2 = p.sub(this.center);
            return v2.scale(1 / radius);
        }
        public float intersect(Ray ray)
        {
            P3 E = ray.origin;
            P3 O = this.center;
            P3 EO = O.sub(E);
            P3 V = ray.direction;
            float r = this.radius;
            float v = EO.dotProduct(V);
            float dot = EO.dotProduct(EO);
            float disc = (r * r) - (dot - (v * v));
            if (disc < 0)
            {
                return -1;
            }
            else
            {
                float d = (float)Math.Sqrt(disc);
                float time = (v - d);
                if (time < 0)
                {
                    return -1;
                }
                   return time;
            }
        }

        public P2 toP2(P3 p)
        {
                P3 Vp = this.normal(p);
                float b = -Vn.dotProduct(Vp);
                float h = Vp.dotProduct(Ve);
               
                float u;

                float dotProduct = (float)Math.Min(1, Math.Max(-1, b));
                float phi = (float)Math.Acos(dotProduct);
                float v = (float)(phi / Math.PI);
                float dotCross = Vp.dotProduct(P3.crossProduct(Vn,Ve));
                float dotProduct2 = (float)Math.Min(1, Math.Max(-1, h / Math.Sin(phi)));
                float theta = (float)((Math.Acos(dotProduct2)) / (2 * Math.PI));
                if(dotCross > 0)
                {
                    u = theta;
                }
                else
                {
                    u = 1 - theta;
                }

                return new P2(u, v);
            
        }
    }
}
