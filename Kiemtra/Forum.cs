using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Kiemtra
{
    class Forum
    {
        public SortedList<int, Post> Posts = new SortedList<int, Post>();

        public static int increID = 0;
        public void AddPost()
        {
            increID++;
            var _post = new Post();
            _post.Id = increID;
            Console.Write("Title: ");
            _post.Title = Console.ReadLine();
            Console.Write("Author: ");
            _post.Author = Console.ReadLine();
            Console.Write("Content: ");
            _post.Content = Console.ReadLine();
            Posts.Add(_post.Id, _post);
        }
        public void UpdatePost(int id)
        {
            if (Posts.ContainsKey(id))
            {
                Console.WriteLine("enter content: ");
                Posts[id].Content = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("not allow");
            }
        }
        public void RemovePost(int id)
        {
            if (Posts.ContainsKey(id))
            {
                Posts.Remove(id);
            }
            else
            {
                Console.WriteLine("not allow");
            }

        }
        public void ShowPost()
        {
            Console.WriteLine("Id\t\ttitle\t\tauthor\t\tcontent\t\tcount\t\taverageRate");
            ICollection key = (ICollection)Posts.Keys;
            foreach (int k in key)
            {
                Posts[k].Display();
            }
        }
        public Post ShowPostByTitle(string title)
        {
            for (int i = 0; i < Posts.Count; i++)
            {
                if (Posts[i].Title.ToUpper() == title.ToUpper())
                    return Posts[i];
            }
            return null;
        }
        public void Rating(int id)
        {
            if (Posts.ContainsKey(id))
            {
                Console.WriteLine("How many times do you want to rate?: ");
                int length = int.Parse(Console.ReadLine());
                Array.Resize(ref Posts[id].Rates, length);
                Posts[id].count = length;
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Enter your rate {i + 1}: ");
                    Posts[id].Rates[i] = int.Parse(Console.ReadLine());
                }
                Posts[id].CalculatorRate();
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }




    }
}
