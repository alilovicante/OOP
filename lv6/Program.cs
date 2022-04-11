using System;
using System.Collections.Generic;
using System.Text;

namespace lv6
{
    class Program
    {
        static void Main() { RunExercise1(); }
        static void RunExercise2()
        {
            Random generate = new Random();
            int n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                list.Add(generate.Next(-10,11));
            }
            Func<int, bool> DivisibleBy3 = x => x % 3 == 0;
            Func<int, bool> IsInRange = x =>
            {
                if (x >= -5 && x <= 5) { return true; }
                else return false;
            };
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            list1 = Utilities.Filter(list, DivisibleBy3);
            list2 = Utilities.Filter(list, IsInRange);
            Console.WriteLine(string.Join("\n", list1));
            Console.WriteLine("||||||||||||||||||||||||||");
            Console.WriteLine(string.Join("\n", list2));
        }
        static void RunExercise1()
        {
            Post post1 = new Post("Dorijan", "Di si?", new List<string>());
            Post post2 = new Post("Ich", "Kako si?", new List<string>());
            Post post3 = new Post("Babos", "Djir!", new List<string>());

            post1.Tag("#lib");
            post2.Tag("#hel");
            post3.Tag("#bii");

            Dictionary<string, Post> popis = new Dictionary<string, Post>();
            popis.Add("Dorijan", post1);
            popis.Add("Ich", post2);
            popis.Add("Babos", post3);
            Console.WriteLine(Post.GetAsString(popis));
            Dictionary<string, Post> popisKopija = new Dictionary<string, Post>();
            foreach (string key in popis.Keys)
            {
                popisKopija[key] = new Post(popis[key]);
                popisKopija[key].Untag();
            }
            Console.WriteLine(Post.GetAsString(popisKopija));
        }
    }
}
