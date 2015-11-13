using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class Directional: Light
    {
        public P3 direction;
        public RColor color;

        public Directional(RColor color, P3 direction)
        {
            this.color = color;
            this.direction = direction.normalize();
        }

        public RColor illumination(P3 p, SceneObject so)
        {
            P3 surfaceNormal = so.shape.normal(p);
            float shade = surfaceNormal.dotProduct(this.direction);
            

            if (shade < 0) 
            {
                return new RColor(0, 0, 0);                                   
            }
            else
            {
                return this.color.scalarMultiply(shade);
            }  
        }
    }
}
