using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public interface Geometry
    {

        float intersect(Ray r);
        P3 normal(P3 p);
        P2 toP2(P3 p);

    }
}
