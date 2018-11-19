using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class M3:BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\tHP: {1}\tColor: {2}", brand, HP, Color);
        }

        public override void Repair()
        {
            base.Repair();
        }
    }
}
