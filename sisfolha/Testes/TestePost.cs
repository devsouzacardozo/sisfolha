using sisfolha.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace sisfolha.Testes {
    class TestePost {
        public static void testePost() {
            Comment c1 = new Comment("Have a nice trip: ");
            Comment c2 = new Comment("Wow that's aweme! ");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zeland",
                "I'm going to visit this worderful country",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night: ");
            Comment c4 = new Comment("May the Force be With you! ");

            Post p2 = new Post(
                DateTime.Parse("28/06/2018 13:05:44"),
                "good night guys",
                "See you tomorrow",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
