using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    abstract class TechFactory
    {
        public abstract Smartphone CreateSmartphone();
        public abstract Smartwatch CreateSmartwatch();
    }
}
