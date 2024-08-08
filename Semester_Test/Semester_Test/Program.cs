using System;

namespace Semester_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2 - question 1
            Library Dung_Library = new Library("Librarys");
            Book harry_potter = new Book("Harry Potter", "J. K. Rowling", "9780747532743");
            Book under_the_sea = new Book("20,000 Leagues Under the Sea", "Jule Vernes", "9781440414268");
            Game csgo = new Game("CSGO", "Valve", "PG17");
            Game little_nightmare = new Game("Little Nightmare", "Tarsier Studios", "PG16");

            harry_potter.OnLoan = true;
            csgo.OnLoan = true;

            Dung_Library.AddResource(harry_potter);
            Dung_Library.AddResource(under_the_sea);
            Dung_Library.AddResource(csgo);
            Dung_Library.AddResource(little_nightmare);

            //Step 3 - question 1
            Console.WriteLine(Dung_Library.HasResource("20,000 Leagues Under the Sea")); // Checking whether "20,000 Leagues Under the Sea" is on loan or not
            Console.WriteLine("20,000 Leagues Under the Sea is currently not on loan.");

            Console.WriteLine(Dung_Library.HasResource("Little Nightmare")); // Checking whether "Little Nightmare" is on loan or not
            Console.WriteLine("Little Nightmare is currently not on loan.");

            //Step 4 - question 1
            Console.WriteLine(Dung_Library.HasResource("Harry Potter")); // Checking whether "Harry Potter" is on loan or not
            Console.WriteLine("Harry Potter is currently on loan.");

            Console.WriteLine(Dung_Library.HasResource("CSGO")); // Checking whether "Harry Potter" is on loan or not   
            Console.WriteLine("CSGO is currently on loan.");
        }
    }
}

//Tran Quoc Dung 103803891