using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    
    class BMW:Car
    {
        public string Model { get; set; }
        public string brand = "BMW";
        public BMW(int hp, string color, string model):base(hp, color)
        {
            //includes Car constructor
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\tHP: {1}\tColor: {2}", brand, HP, Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The BMW {0} is repaired", Model);
        }
    }
}
