using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public interface Light
    {

        RColor illumination(P3 p, SceneObject so);
    }
}
