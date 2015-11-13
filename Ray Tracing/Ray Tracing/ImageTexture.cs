using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class ImageTexture: Texture
    {
        public Bitmap image;

        public ImageTexture(Bitmap image)
        {
            this.image = image;
        }

        public RColor texture(P2 p)
        {
            throw new NotImplementedException();
        }
    }
}
