namespace Semester_Test
{
    class Game : LibraryResource
    {
        string r;
        string dev;
        public Game(string name, string developer, string rating) : base(name)
        {
            r = rating;
            dev = developer;
        }

        public string Rating
        {
            get
            {
                return r;
            }
        }

        public override string Developer
        {
            get
            {
                return dev;
            }
        }
    }
}

//Tran Quoc Dung 103803891