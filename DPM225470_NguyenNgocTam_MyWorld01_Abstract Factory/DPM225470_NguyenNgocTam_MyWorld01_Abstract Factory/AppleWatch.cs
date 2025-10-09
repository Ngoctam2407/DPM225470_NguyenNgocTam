using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class AppleWatch : Smartwatch
    {
        public override void ConnectToPhone(Smartphone phone)
        {
            Console.WriteLine(" Apple Watch Ultra connected to {phone.GetType().Name}");
        }
    }
}
