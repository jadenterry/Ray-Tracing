using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class Ambient: Light
    {
        public RColor color;
        public Ambient(RColor color)
        {
            this.color = color;
        }

        public RColor illumination(P3 p, SceneObject so)
        {
            return this.color;
        }
    }
}
