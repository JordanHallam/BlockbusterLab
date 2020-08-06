using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD:Movie
    {
        public DVD() { }
        public DVD(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)
        {

        }
        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine((i+1) + Scenes[i]);
            }
            int chooseScene = int.Parse(Console.ReadLine())-1;
            Console.WriteLine(Scenes[chooseScene]);

        }


    }
}
