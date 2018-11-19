using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class Car
    {
        public int HP { set; get; }
        public string Color { set; get; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: {0} color: {1}", HP, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car is repaired");
        }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car ID is: {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }
    }
}
