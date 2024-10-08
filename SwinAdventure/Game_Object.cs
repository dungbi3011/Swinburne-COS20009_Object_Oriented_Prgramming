﻿namespace SwinAdventure.Abstract
{
    public abstract class GameObject : IdentifiableObject
    {
        private readonly string _name;
        private readonly string _description;

        public GameObject(string name, string description, string[] ids) : base(ids)
        {
            _name = name;
            _description = description;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string ShortDescription
        {
            get
            {
                return $"{_name} ({FirstId})";
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }
    }
}

//Tran Quoc Dung 103803891