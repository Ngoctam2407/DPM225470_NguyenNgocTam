using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class SamsungFactory : TechFactory
    {
        public override Smartphone CreateSmartphone()
        {
            return new GalaxyPhone();
        }
        public override Smartwatch CreateSmartwatch()
        {
            return new GalaxyWatch();
        }
    }
}
