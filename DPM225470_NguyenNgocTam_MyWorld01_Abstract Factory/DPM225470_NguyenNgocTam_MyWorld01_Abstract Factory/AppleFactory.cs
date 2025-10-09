using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class AppleFactory : TechFactory
    {
        public override Smartphone CreateSmartphone()
        {
            return new IPhone();
        }
        public override Smartwatch CreateSmartwatch()
        {
            return new AppleWatch();
        }
    }
}
