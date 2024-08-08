namespace Semester_Test
{
    class Book : LibraryResource
    {
        string interStandBookNo;
        string author;
        public Book(string name, string developer, string isbn) : base(name)
        {
            interStandBookNo = isbn;
            author = developer;
        }
        public override string Developer
        {
            get
            {
                return author;
            }
        }
        public string ISBN
        {
            get
            {
                return interStandBookNo;
            }
        }


    }
}

//Tran Quoc Dung 103803891