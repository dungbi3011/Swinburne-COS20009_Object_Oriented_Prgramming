using SwinAdventure.Abstract;
using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    class Application
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your name here: ");
            string pName = Console.ReadLine();
            Console.WriteLine("Give a description about yourself: ");
            string pDesc = Console.ReadLine();

            Player player = new Player(pName, pDesc);
            Console.WriteLine("Welcome " + pName + ", " + pDesc);

                //Smaller Item
            Item bow = new Item(new string[] { "bow" }, "extra-powerful bow",
                "The extra-powerful bow can kill 10 people within a shot.");
            Item gun = new Item(new string[] { "gun" }, "silver gun",
                "A powerful silver gun.");
            Item shoes = new Item(new string[] { "shoes" }, "boosted shoes",
                "Boosted shoes can help you run faster.");

                //Bag
            Bag bag = new Bag(new string[] { "military bag" }, "military bag",
                "It is my largest bag.");

            Inventory inventory = new Inventory(pName, pDesc);
            inventory.Put(bow);
            inventory.Put(gun);
            inventory.Put(bag);
            inventory.Put(shoes);
            Console.WriteLine("Look at item by entering 'look at <item>', end program by typing end");
            Look_Command look = new Look_Command();
            string playerCommand = null;

            while (playerCommand != "end")
            {
                playerCommand = Console.ReadLine();
                look.Execute(player, playerCommand.Split());
                Console.WriteLine(look.Execute(player, playerCommand.Split() ));
            }
        }
    }
}

//Tran Quoc Dung 103803891
