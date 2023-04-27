using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lumpkin_Dalton
{
    class FPS : Game
    {
        public FPS(string esbr, string title) : base(esbr, title)
        {
            //sets the Title and ESBR properties
            Title = title;
            ESBR = esbr;
        }

        //override thingy
        public override string Describe()
        {
            //desribes game game
            return $"The game {Title} is an FPS and has an ESBR rating of {ESBR}";
        }
    }
}
