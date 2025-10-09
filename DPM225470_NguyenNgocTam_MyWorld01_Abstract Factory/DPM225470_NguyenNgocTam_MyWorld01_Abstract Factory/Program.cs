using System;
namespace DPM225470_NguyenNgocTam_MyWorld_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== APPLE ECOSYSTEM ===");
            TechFactory apple = new AppleFactory();
            TechEcosystem appleEco = new TechEcosystem(apple);
            appleEco.ShowEcosystem();

            Console.WriteLine("\n=== SAMSUNG ECOSYSTEM ===");
            TechFactory samsung = new SamsungFactory();
            TechEcosystem samsungEco = new TechEcosystem(samsung);
            samsungEco.ShowEcosystem();

            Console.ReadKey();
        }
    }
}