using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BaoTri
{
    using System.Collections.Generic;

    public class FolderComposite : IComponent
    {
        public string Name { get; set; }
        private List<IComponent> _children = new List<IComponent>();

        public FolderComposite(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public double GetSize()
        {
            double total = 0;
            foreach (var child in _children)
            {
                total += child.GetSize();
            }
            return total;
        }
    }

}
