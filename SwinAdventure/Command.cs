namespace SwinAdventure.Abstract
{
    public abstract class Command : IdentifiableObject
    {

        public Command(string[] ids) : base(ids)
        {

        }

        public abstract string Execute(Player p, string[] text);
    }
}

//Tran Quoc Dung 103803891