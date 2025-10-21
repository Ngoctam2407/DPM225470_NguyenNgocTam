using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BaoTri
{
    public interface IComponent
    {
        string Name { get; }
        double GetSize();
    }

}
