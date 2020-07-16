using System;
using System.Security.Cryptography.X509Certificates;

namespace Kiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
            }
                
           
        }
        public static Forum forum = new Forum();
        public static void ShowMenu()
        {
            string choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create Post");
            Console.WriteLine("2. Update Post");
            Console.WriteLine("3. Remove Post");
            Console.WriteLine("4. Show Posts");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Rating");
            Console.WriteLine("7. Exit");

            Console.WriteLine("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Create Post:");
                    forum.AddPost();
                    forum.ShowPost();
                    break;
                case "2":
                    Console.WriteLine("Update Post");
                    Console.WriteLine("Enter Post's id you need to update");
                    int id = int.Parse(Console.ReadLine());
                    forum.UpdatePost(id);
                    forum.ShowPost();
                    break;
                case "3":
                    Console.WriteLine("Remove Post");
                    Console.WriteLine("Enter Post's id you need to remove");
                    int _id = int.Parse(Console.ReadLine());
                    forum.RemovePost(_id);
                    forum.ShowPost();
                    break;
                case "4":
                    Console.WriteLine("Show all Post");
                    forum.ShowPost();
                    break;
                case "5":
                    Console.WriteLine("Search:");
                    Console.WriteLine("Enter Post's title you need to search");
                    string title = Console.ReadLine();
                    Console.WriteLine(forum.ShowPostByTitle(title));
                    break;
                case "6":
                    Console.WriteLine("Rating");
                    Console.WriteLine("Enter id:");
                    int id_ = int.Parse(Console.ReadLine());
                    forum.Rating(id_);
                    forum.ShowPost();
                    break;
                case "7":
                    Environment.Exit(7);
                   break;

            }
        }
    }

}



