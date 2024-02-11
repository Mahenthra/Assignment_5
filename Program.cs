using System;
using Asignment_5;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different product classes
            Sofa sofa = new Sofa("Comfortable Sofa", 499.99f);
            Basket basket = new Basket("Storage Basket", 19.99f);
            Bookshelf bookshelf = new Bookshelf("Wooden Bookshelf", 149.99f);
            CookingPot cookingPot = new CookingPot("Stainless Steel Cooking Pot", 29.99f);
            Desk desk = new Desk("Office Desk", 199.99f);
            Carpet carpet = new Carpet("Soft Carpet", 79.99f);
            DeskLamp deskLamp = new DeskLamp("LED Desk Lamp", 29.99f);
            ChildsBed childsBed = new ChildsBed("Wooden Bed", 299.99f);

            // Display information about each product
            Console.WriteLine("Information about products:");
            Console.WriteLine("=======================================");
            Console.WriteLine("Sofa: " + sofa.Description());
            Console.WriteLine("Basket: " + basket.Description());
            Console.WriteLine("Bookshelf: " + bookshelf.Description());
            Console.WriteLine("Cooking Pot: " + cookingPot.Description());
            Console.WriteLine("Desk: " + desk.Description());
            Console.WriteLine("Carpet: " + carpet.Description());
            Console.WriteLine("Desk Lamp: " + deskLamp.Description());
            Console.WriteLine("Child's Bunk Bed: " + childsBed.Description());

            // Call methods specific to certain interfaces
            Console.WriteLine("\nAdditional Information:");
            Console.WriteLine("=======================================");
            Console.WriteLine("Living Room message for Sofa: " + sofa.LivingRoom());
            Console.WriteLine("Assemble instructions for Sofa: " + sofa.Assemble());
            Console.WriteLine("Office message for Desk: " + desk.Office());
            Console.WriteLine("Kitchen message for Cooking Pot: " + cookingPot.Kitchen());
            Console.WriteLine("Bedroom message for Child's Bunk Bed: " + childsBed.Bedroom());
        }
    }
}
    