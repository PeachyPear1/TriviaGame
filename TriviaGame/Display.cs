using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TriviaGame
{
    class Display
    {
        public static string Points { get; set; }
        //int QuestionsLeft = 0;
        //int Time = 0;

        public Display()
        {
            ShowPoints();
            ShowNumberofQuestions();
            //ShowClock();
        }

        public static void ShowPoints()
        {
            Display.Points = "1";
            WriteLine($"You now have {Display.Points} point!");
            WriteLine("Press enter to continue.");
            ReadKey();
            Game.CheckResponse();
        }

        public static void ShowNumberofQuestions()
        {
            Display.Points = "2";
            WriteLine($"You now have {Display.Points} points!");
            WriteLine("Press enter to continue.");
            ReadKey();
            Game.End();
        }

        /*public static void ShowClock()
        *{
        *
        *}*/
    }
}
