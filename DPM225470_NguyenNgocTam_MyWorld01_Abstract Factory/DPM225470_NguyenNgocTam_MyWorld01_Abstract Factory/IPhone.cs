using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class IPhone:Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine(" iPhone 15 Pro – Chip A17, iOS 18");
        }
    }
}
