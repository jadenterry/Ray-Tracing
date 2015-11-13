using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class SceneObject
    {
        public Geometry shape;
        public Texture texture;
        public Skin skin;

        public SceneObject(Geometry shape, Texture texture, Skin skin)
        {
            this.shape = shape;
            this.texture = texture;
            this.skin = skin;
        }
        public float distance(Ray r)
        {
            return shape.intersect(r);
        }
        public RColor colorAt(P3 p, Ray r)
        {
            return skin.Coloring(p, r, this);
               
        }

    }
}
