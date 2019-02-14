using System;
using Cap9Ex3.Entities;

namespace Cap9Ex3 {
    class Program {
        static void Main(string[] args) {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Woe that's awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm Going to visit this wonderful conntry", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
            Console.ReadLine();





        }
    }
}
