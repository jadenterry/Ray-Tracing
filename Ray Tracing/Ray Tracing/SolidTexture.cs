using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class SolidTexture: Texture
    {
        public RColor c;

        public SolidTexture(RColor c)
        {
            this.c = c;
        }

        public RColor texture(P2 p)
        {
            return this.c;
        }
    }
}
