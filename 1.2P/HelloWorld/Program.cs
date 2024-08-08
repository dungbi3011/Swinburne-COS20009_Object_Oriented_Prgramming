using System;

namespace HelloWorld
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] message = new string[4];
            message[0] = new string("Welcome back oh great educator") ;
            message[1] = new string("What a lovely name");
            message[2] = new string("Great name");
            message[3] = new string("That's a silly name");
            Console.WriteLine("Enter name:");
            string line = Console.ReadLine();

            if (!string.IsNullOrEmpty(line))
            {
                switch (line)
                {
                    case "Dung":
                        Console.WriteLine(message[0]);
                        break;
                    case "Samuel":
                        Console.WriteLine(message[1]);
                        break;
                    case "Ben":
                        Console.WriteLine(message[2]);
                        break;
                    default:
                        Console.WriteLine(message[3]);
                        break;
                }
            }
            else
            {
                Console.WriteLine("If there is no name, I can not work properly!");
            }
        }
    }
}