using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class NonReflective: Skin
    {
        public NonReflective() { }

        public RColor Coloring(P3 p, Ray r, SceneObject so)
        {
            P2 textureLoc = so.shape.toP2(p);
            RColor textureColor = so.texture.texture(textureLoc);
            RColor sumOfLights = new RColor(0, 0, 0);
            RColor lightColor;
            foreach (Light lightSource in Form1.lights)
            {
                lightColor = lightSource.illumination(p,so);
                sumOfLights = sumOfLights.add(lightColor);
            }
            
            return RColor.multiplyColor(textureColor, sumOfLights);
           
        }

    }
}
