using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        List<Movie> rentableMovies = new List<Movie>
        {
            new DVD("Spider-Man 2", Genre.Action, 121, new List<string> { "Sannd guy shows up.", "Peter parker goes emo", "Now dig on this", "Mary Jane cries", "Spidey does spider stuff" }),
            new DVD("Eurovision Song Contest: The Story of Fire Saga", Genre.Comedy,123, new List<string>{"Will Ferrell does bad, possibly offensive Icelandic accent.", "Weird pop mashup music video","Fire Saga breaks up ):", "Fire Saga gets back together (:"}),
            new DVD("John Wick", Genre.Action, 82,new List<string>{"John Wick's wife dies ):", "John Wick gets a puppy! (:", "John Wick's dog dies ):", "John Wick makes everyone else die ):<" }),
            new VHS("Spirited Away", Genre.Drama, 125, new List<string>{"Family vacay!!","Parents pig out!", "weird spirit bathouse stuff","Soot balls are creepy and cute", "Creepy crow lady is mean!"},0),
            new VHS("The Matrix", Genre.Action, 150, new List<string>{"Mr. Anderson is a hacker with sweet skillz and gets courted by punk lady in latex","Neo learns about the Matix and says,'woah'", "Neo learns Kung-Fu","Neo dodges bullets and does some Super Man stuff." }, 0),
            new VHS("Beauty and the Beast", Genre.Romance,92, new List<string>{"Lady comes to castle", "Lasy befirends some furniture", "Lady falls in love with hairy beast guy","Beast and lady dance in ballroom"},0)

        };
        public void PrintMovies()
        {
            int index = 1;
            foreach (Movie movie in rentableMovies)
            {
                Console.WriteLine($"{index} {movie.Title}");
                index++;
            }
        }
        public Movie CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to check out?");
            int index = int.Parse(Console.ReadLine()) - 1;
            rentableMovies[index].PrintInfo();
            return rentableMovies[index];

        }

    }
}
