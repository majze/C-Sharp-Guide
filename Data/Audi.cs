using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    // sealed closes this class from further inheritence
    sealed class Audi :Car
    {
        public string Model { get; set; }
        public string brand = "BMW";
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            //includes Car constructor
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\tHP: {1}\tColor: {2}", brand, HP, Color);
        }

        // sealed allows no more inheritence of the overridden function
        public sealed override void Repair()
        {
            Console.WriteLine("The Audi {0} is repaired", Model);
        }
    }
}
