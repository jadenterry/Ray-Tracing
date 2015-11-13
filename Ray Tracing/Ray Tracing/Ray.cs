using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class Ray
    {
        public P3 direction;
        public P3 origin;

        public Ray(P3 origin, P3 direction)
        {
            this.direction = (direction).normalize();
            this.origin = origin;
        }

        public P3 travel(float time)
        {
            return origin.add(direction.scale(time));
        }
    }
}
