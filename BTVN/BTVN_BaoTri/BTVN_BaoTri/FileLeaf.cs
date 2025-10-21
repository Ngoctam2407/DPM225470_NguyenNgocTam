using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BaoTri
{
    public class FileLeaf : IComponent
    {
        public string Name { get; set; }
        public double Size { get; set; }

        public FileLeaf(string name, double size)
        {
            Name = name;
            Size = size;
        }

        public double GetSize()
        {
            return Size;
        }
    }

}
