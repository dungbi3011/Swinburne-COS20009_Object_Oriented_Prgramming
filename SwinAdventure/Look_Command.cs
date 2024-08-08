using System;
using System.Linq;
using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(ids: new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Count() != 3 && text.Count() != 5)
            {
                return "\nWhat do you want to look at? \nPlease type {Look at ... or Look at ... in ...}.\n";
            }

            if (text[0].ToLower() != "look")
            {
                return "\nWhat do you want to look at? \nPlease type {Look at ... or Look at ... in ...}.\n";
            }

            if (text[1].ToLower() != "at")
            {
                return "\nWhat do you want to look at? \nPlease type {Look at ... or Look at ... in ...}.\n";
            }

            if (text.Length == 5)
            {
                if (text[3].ToLower() != "in")
                {
                    return "\nWhat do you want to look at? \nPlease type {Look at ... or Look at ... in ...}.\n";
                }
            }

            if (text.Length == 3)
            {
                string itemToFind = text[2].ToLower();
                return LookAtIn(itemToFind, p as IHaveInventory);
            }

            if (text.Length == 5)
            {
                string itemToFind = text[2].ToLower();
                string placeToLookIn = text[4].ToLower();
                IHaveInventory container = FetchContainer(p, placeToLookIn);
                if (container is null)
                {
                    return $"I cannot find the {placeToLookIn}\n";
                }
                return LookAtIn(itemToFind, container);
            }

            return "Success";
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            if (p.AreYou(containerId))
            {
                return p;
            }

            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }

            return $"I can't find the {thingId}";
        }

    }

    public interface IHaveInventory
    {
        public GameObject Locate(string id);

        public string Name
        {
            get;
        }
    }

}