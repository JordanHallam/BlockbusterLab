using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS() { }
        public VHS(string title, Genre category, int runTime, List<string> scenes, int currentTime) : base(title, category, runTime, scenes)
        {
            CurrentTime = currentTime;
        }
        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }

            else
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
        
    }
}
