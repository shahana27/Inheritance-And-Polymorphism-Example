using System;

namespace Inheritance_Example
{
    class Nokia : Mobile, FunctionCaller
    {
        public void ShowDetails()
        {
            Console.WriteLine("\n");
            DisplayDetailsOfMobile("Nokia", "Black",12999);
            DisplayDetailsOfMobile("3 GB", "32 GB", "6 hours");//Static Polymorphism
        }

        public override void Features() //Dynamic Polymorphism
        {
            Console.WriteLine("\n");
            Console.WriteLine("Salient Features of Nokia Phones are : ");
            Console.WriteLine(@"                                      Dual Sim, 4G, VoLTE, Wi-Fi
                                2000 mAh Battery
                                2.4 inches, 240 x 320 px Display
                                43 MP Rear & 23 MP Front Camera
                                Memory Card Supported, upto 64 GB
                                Bluetooth
                                Browser");
        }
    }
}