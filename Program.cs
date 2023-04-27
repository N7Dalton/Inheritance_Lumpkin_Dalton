using System;

namespace Inheritance_Lumpkin_Dalton
{
    class Program
    {       
        static void Main(string[] args)
        {
          FPS XDefiant = new FPS("Teen", "XDefiant");
          Console.WriteLine(XDefiant.Describe());
          XDefiant.PlayGame();
        }
        
    }
}
