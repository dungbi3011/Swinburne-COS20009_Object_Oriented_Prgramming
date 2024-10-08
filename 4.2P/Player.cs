﻿using System;
using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Player : Game_Object, Inventory
    {
        private Inventory _inventory;

        public Player(string name, string description) :
            base(name, description, new[] { "me", "inventory" })
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get
            {
                return $"You are {this.Name} {base.FullDescription}\nYou are carrying:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}
