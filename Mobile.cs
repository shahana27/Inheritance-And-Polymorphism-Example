using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Example
{
    class Mobile
    {
        private string name;
        private string color;
        private string ram;
        private string external_memory;
        private string battery_life;
        private int price;

        public void DisplayDetailsOfMobile(string name,string color,int price)
        {
            this.name = name;
            this.color = color;
            this.price = price;

            Console.WriteLine("Name of the mobile : " + this.name);
            Console.WriteLine("Color of the mobile : " + this.color);
            Console.WriteLine("Price of the mobile : " + this.price);
        }

        public void DisplayDetailsOfMobile(string ram, string external_memory, string battery_life) //Function Overloading (Static Polymorphism)
        {
            this.ram = ram;
            this.external_memory = external_memory;
            this.battery_life = battery_life;
            Console.WriteLine("RAM of the mobile : " + this.ram);
            Console.WriteLine("External_Memory of the mobile : " + this.external_memory);
            Console.WriteLine("Battery Life of the mobile : " + this.battery_life);
        }

        public virtual void Features() //virtual function (Dynamic Polymorphism)
        {
            Console.WriteLine("Every Mobile phone has separate features.");
        }
    }
}
