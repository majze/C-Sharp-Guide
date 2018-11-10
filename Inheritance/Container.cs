using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class Container
    {
        protected string Name { set; get; }

        public Container() { }
        public Container(string name)
        {
            Console.WriteLine("Container created with id: " + name);
            this.Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }

    class Box : Container
    {
        protected double Volume { set; get; }

        public Box() { }
        public Box(string name, double volume)
        {
            Console.WriteLine("Box created with id: {0}, vol of {1}", name, volume);
            this.Name = name;
            this.Volume = volume;
        }
    }

    class ShippingBox : Box
    {
        protected double length, width, height, maxLoad;
        protected string Contents { set; get; }

        public ShippingBox() { }
        public ShippingBox(string n, double l, double w, double h, double mL)
        {
            Console.WriteLine("ShippingBox created with id: {0}, vol of {1}, maxLoad of {2}", n, l*w*h, mL);
            this.Name = n;
            this.length = l;
            this.width = w;
            this.height = h;
            this.Volume = l * w * h;
            this.maxLoad = mL;
        }

        public bool CheckSize(double l, double w, double h, double load)
        {
            if (l*w*h >= Volume)
            {
                return false;
            } else
            {
                if (length <= l)
                    return false;
                if (width <= w)
                    return false;
                if (height <= h)
                    return false;
                if (maxLoad <= load)
                    return false;
                return true;
            }
        }

        public void storeItem(string itemName)
        {
            this.Contents = itemName;
        }

        public void CheckContent()
        {
            if (Contents != null)
            {
                Console.WriteLine("{0} has {1} inside and is ready to ship", Name, Contents);
            } else
            {
                Console.WriteLine("{0} is empty and awaiting an item", Name);
            }
        }
    }

    class Item
    {
        protected string Name { set; get; }
        public double Weight { set; get; }
        public double length, width, height;

        public Item() { }
        public Item(string name, double l, double w, double h, double mass)
        {
            this.Name = name;
            this.Weight = mass;
            this.length = l;
            this.width = w;
            this.height = h;
            Console.WriteLine("Item created: {0}, weights {1}", Name, Weight);
        }

        public void ShipItem(ShippingBox nextBox)
        {
            if (nextBox.CheckSize(length, width, height, Weight) == true)
            {
                Console.WriteLine("It fits! Inserting {0} into {1}", this.Name, nextBox.GetName());
                nextBox.storeItem(Name);
            } else
            {
                Console.WriteLine("{0} does not fit or is too heavy for {1}", Name, nextBox.GetName());
            }
        }
    }
}
