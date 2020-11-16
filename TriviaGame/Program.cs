using System;

namespace TriviaGame
{
    //Triva Game by Hannah Hamilton
    //Date Created: 09/21/2020
    //For: Intro to Programming
    class Program
    {
        static void Main()
        {
            Game.Start();
            Game.ShowWelcome();
            TriviaItem.ShowText();
            Game.ShowQuestion();
        }
    }
    
}
