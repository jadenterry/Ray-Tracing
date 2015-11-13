using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public interface Skin
    {

        RColor Coloring(P3 p, Ray r, SceneObject so);
       
    }
}
