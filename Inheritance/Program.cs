using System;
using System.Collections;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating objects!");
            ArrayList myObjects = new ArrayList();
            myObjects.Add(new Container("The Solar System"));
            myObjects.Add(new Box("Trash Dumpster", 400560));
            myObjects.Add(new ShippingBox("Amazon N3", 16.25, 12, 5.25, 4600));
            myObjects.Add(new ShippingBox("Furniture Box", 120, 56, 56, 76000));
            myObjects.Add(new Item("Hockey Stick", 60, 11, 3.5, 1200));

            Console.WriteLine("\nNow to test the boxes!");
            (myObjects[2] as ShippingBox).CheckContent();
            (myObjects[3] as ShippingBox).CheckContent();
            (myObjects[4] as Item).ShipItem((myObjects[2] as ShippingBox));
            (myObjects[4] as Item).ShipItem((myObjects[3] as ShippingBox));
            (myObjects[2] as ShippingBox).CheckContent();
            (myObjects[3] as ShippingBox).CheckContent();

            Console.WriteLine("\nNow to test the online posts!");
            Post myPost = new Post("Angry Rant", true, "Jessi J");
            Console.WriteLine(myPost.ToString());
            Post myImagePost = new ImagePost("New shoes", "Mikey M", "https://i.imgur.com/FRWds45.jpg", true);
            Console.WriteLine(myImagePost.ToString());
            VideoPost myVid = new VideoPost("Funny cats", "Amy A", "youtu.be/catz9", true, 180);
            Console.WriteLine(myVid.ToString());

            Console.WriteLine("\nLet's watch the cat video! Press any key to play or stop!");
            Console.ReadKey();
            myVid.Play();
            Console.ReadKey();
            myVid.Stop();
            Console.WriteLine("Video stopped playing!");
            Console.ReadKey();
        }
    }
}
