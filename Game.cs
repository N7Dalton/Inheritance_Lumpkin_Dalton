using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lumpkin_Dalton
{
    abstract class Game
    {
        public Game(string esbr, string title)
        {
            ESBR = esbr;
            Title = title;
        }
        public string ESBR
            //get and setter
        { get; set; }

        public string Title
        {
            //fun get and set :)
            get; set;
        }
        //when PlayGame is called it literally just says the game is starting
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        public abstract string Describe();

    }
}
