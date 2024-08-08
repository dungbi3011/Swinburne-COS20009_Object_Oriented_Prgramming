using System;

namespace SwinAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SWIN ADVENTURE Introducing!!!");
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("Give a description about yourself: ");
            string description = Console.ReadLine();
            Player player = new Player(name, description);

            //items creating
            string[] Gun = { "gun", "AWP", "Sniping" };
            Item awp = new Item(Gun, "Sniping Gun", "AWP: The strongest and most accurate gun in the game.");
            player.Inventory.Put(awp);

            string[] Armour = { "giap", "armor", "Heavy Armour" };
            Item armour = new Item(Armour, "Armour lv3", "Armor lv3: The strongest and hardest armor in the game.");
            player.Inventory.Put(armour);

            //bag
            string[] Bag = new[] { "bag", "backpack" };
            Bag bag = new Bag(Bag, "Military Bag", "My favorite and largest bag.");
            player.Inventory.Put(bag);

            //items in backpack
            string[] Shoes = { "shoes", "usable", "Boosting" };
            Item food = new Item(Shoes, "Silver shoes", "Silver Shoes can boost your speed 15%.");
            bag.Inventory.Put(food);

            Console.WriteLine("Search for item by entering 'look at <item>' OR 'look at <item> in <bag>', end program by typing 'end'. \n");
            string[] choiceList = new[] { "" };
            while (choiceList[0] != "end")
            {
                LookCommand look = new LookCommand();
                Console.Write("\nWhat do you want to look at? ");
                string choice = Console.ReadLine();
                choiceList = choice.Split(" ");
                Console.Write(look.Execute(player, choiceList));
            }
        }
    }
}
