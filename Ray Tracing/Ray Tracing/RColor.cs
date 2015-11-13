using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class RColor
    {
        public float r;
        public float g;
        public float b;

        public RColor(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public RColor scalarMultiply(float scale)
        {
            return new RColor(r * scale, g * scale, b * scale);
        }
        public static RColor multiplyColor(RColor c, RColor c2)
        {
            return new RColor(c.r * c2.r, c.b * c2.b, c.g * c2.g);
        }
        public RColor add(RColor c)
        {
            return new RColor(c.r + r, c.g + g, c.b + b); 
        }

        public float intensity()
        {
            return (float)Math.Sqrt(r * r + g * g + b * b);

        }

        public Color convert()
        {
            return Color.FromArgb((int)Math.Min((r * 255),255), (int)Math.Min((g * 255),255),(int)Math.Min((b * 255),255));
        }
    }
}
