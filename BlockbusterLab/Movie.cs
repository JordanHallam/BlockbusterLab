using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
   abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie() { }
        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nRuntime: {RunTime}");
        }

        public virtual void PrintScenes(List<string> scenes)
        {
            foreach(string shot in scenes)
            {
                Console.WriteLine(shot);
            }
        }
        public abstract void Play();

    }
}
