using System;

namespace SwinAdventure.Abstract
{
    public abstract class Look_Command : IdentifiableObject
    {
        public Look_Command(string[] ids) : base(ids)
        {

        }

        public abstract string Execute(Player p, string[] text);
    }
}