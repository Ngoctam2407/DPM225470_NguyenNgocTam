using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class TechEcosystem
    {
        private Smartphone _phone;
        private Smartwatch _watch;

        public TechEcosystem(TechFactory factory)
        {
            _phone = factory.CreateSmartphone();
            _watch = factory.CreateSmartwatch();
        }

        public void ShowEcosystem()
        {
            _phone.DisplayInfo();
            _watch.ConnectToPhone(_phone);
        }
    }
}
