using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;

namespace Kiemtra
{
    class Post : IPost
    {
        private int id;
        private string title;
        private string author;
        private string content;
        private float averageRate;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public float AverageRate { get => averageRate; }
        public int[] Rates ;
        public  float count;
        public float CalculatorRate()
        {
            int total = 0;
            for (int i = 0; i < Rates.Length; i++)
            {
                 total += Rates[i];
            }
           return averageRate = total / Rates.Length;
        }


        public void Display()
        {
            Console.WriteLine($"{Id}\t\t{title}\t\t{author}\t\t{content}\t\t{count}\t\t{averageRate}");
        }
    }
}
