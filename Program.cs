using System;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MI obj1 = new MI();
            Samsung obj2 = new Samsung();
            Nokia obj3 = new Nokia();
            Micromax obj4 = new Micromax();
            Console.WriteLine("Enter the Mobile Name (MI, Samsung, Nokia, Micromax) to see the details: ");
            string mobile_name = Console.ReadLine();
            switch (mobile_name)
            {
                case "MI":
                    obj1.ShowDetails();
                    obj1.Features();
                    break;
                case "Samsung":
                    obj2.ShowDetails();
                    obj2.Features();
                    break;
                case "Nokia":
                    obj3.ShowDetails();
                    obj3.Features();
                    break;
                case "Micromax":
                    obj4.ShowDetails();
                    obj4.Features();
                    break;
                default:
                    Console.WriteLine("Enter Correct Mobile name!");
                        break;
            }
        }
    }
}
