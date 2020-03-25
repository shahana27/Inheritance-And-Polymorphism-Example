using System;

namespace Inheritance_Example
{
    class Micromax : Mobile, FunctionCaller
    {
        public void ShowDetails()
        {
            Console.WriteLine("\n");
            DisplayDetailsOfMobile("Micromax", "Silver",8499);
            DisplayDetailsOfMobile("2 GB", "16 GB", "4 hours");//Static Polymorphism
        }

        public override void Features() //Dynamic Polymorphism
        {
            Console.WriteLine("\n");
            Console.WriteLine("Salient Features of Micromax Phones are : ");
            Console.WriteLine(@"                                Dual Sim, 3G, 4G, VoLTE, Wi-Fi.
                                Helio MT6750, Octa Core, 1.5 GHz Processor.
                                3000 mAh Battery");
        }
    }
}