using System;

namespace Inheritance_Example
{
    class Samsung : Mobile, FunctionCaller
    {
        public void ShowDetails()
        {
            Console.WriteLine("\n");
            DisplayDetailsOfMobile("Samsung", "White",14999);
            DisplayDetailsOfMobile("4 GB", "32 GB", "8 hours");//Static Polymorphism
        }

        public override void Features() //Dynamic Polymorphism
        {
            Console.WriteLine("\n");
            Console.WriteLine("Salient Features of Samsung Phones are : ");
            Console.WriteLine(@"                                Dual Sim, 3G, 4G, VoLTE, Wi-Fi
                                Exynos 9611, Octa Core, 2.3 GHz Processor
                                6000 mAh Battery with Fast Charging
                                6.4 inches, 1080 x 2280 px Display with Water Drop Notch
                                48 MP + 8 MP + 5 MP Triple Rear & 16 MP Front Camera
                                Memory Card Supported, upto 512 GB");
        }
    }
}