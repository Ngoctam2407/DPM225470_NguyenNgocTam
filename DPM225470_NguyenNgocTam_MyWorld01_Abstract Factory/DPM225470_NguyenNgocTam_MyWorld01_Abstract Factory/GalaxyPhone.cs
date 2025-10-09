using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class GalaxyPhone:Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine(" Galaxy S24 Ultra – Snapdragon 8 Gen 3, Android 14");
        }
    }
}
