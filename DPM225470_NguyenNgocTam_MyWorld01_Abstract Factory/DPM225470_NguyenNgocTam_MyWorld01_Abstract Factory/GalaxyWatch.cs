using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class GalaxyWatch:Smartwatch
    {
        public override void ConnectToPhone(Smartphone phone)
        {
            Console.WriteLine(" Galaxy Watch6 connected to {phone.GetType().Name}");
        }
    }
}
