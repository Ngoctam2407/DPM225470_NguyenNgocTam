using System;
using DPM225470_NguyenNgocTam_Real_02_Builder;

namespace DPM225470_NguyenNgocTam_Real_02_Builder
{
    public class MainApp
    {
        public static void Main()
        {
            VehicleBuilder builder;
            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
