using System;

namespace Inheritance_Example
{
    class MI : Mobile , FunctionCaller
    {
        public MI()
        {
        }
        public void ShowDetails()
        {
            Console.WriteLine("\n");
            DisplayDetailsOfMobile("MI","Rose Red",9999);
            DisplayDetailsOfMobile("4 GB", "64 GB", "8 hours");//Static Polymorphism
        }

        public override void Features() //Dynamic Polymorphism
        {
            Console.WriteLine("\n");
            Console.WriteLine("Salient Features of MI Phones are : ");
            Console.WriteLine(@"                                16.0 cm (6.3 inch) Full HD+ Display.
                                48MP + 5MP | 13MP Front Camera.
                                4000 mAh Li-polymer Battery.
                                Qualcomm Snapdragon 675 Processor.
                                Splash Proof - Protected by P2i.
                                Quick Charge 4.0 Support.
                                Brand Warranty of 1 Year Available for Mobile and 6 Months for Accessories.");
        }
    }
}