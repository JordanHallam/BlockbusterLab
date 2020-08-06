using System;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Welcome to Blockbuster!");

                Blockbuster blockbuster = new Blockbuster() { };
                DVD dvd = new DVD() { };
                VHS vhs = new VHS() { };
                Movie rentedMovie = blockbuster.CheckOut();
                WatchMovie(rentedMovie);

                Console.WriteLine("Press 1. to rent another movie, Press 2. to exit");
                int moveOn = int.Parse(Console.ReadLine());
                if (moveOn == 1)
                {
                    continue;
                }
                else if (moveOn == 2)
                {
                    Console.WriteLine("Goodbye, have a nice day");
                    break;
                }
   
                

               




            }
        }

        public static void WatchMovie(Movie rentedMovie)
        {
            int choose = 1;
            while (choose != 3)
            {
                Console.WriteLine("Press 1. to watch movie, press 2. to return movie");
                choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    rentedMovie.Play();
                }
         
                else if (choose == 2)
                {
                    break;
                }
               
                else
                {
                    Console.WriteLine("Please enter a valid number to choose what you would like to do");
                }
            }
        }

    }
}
