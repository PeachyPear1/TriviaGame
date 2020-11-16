using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace TriviaGame
{
    class Game
    {
        static string GameTitle = "Animal Questionnaire by Hannah";

        public Game()
        {
            Start();
            ShowWelcome();
            ShowQuestion();
            CheckResponse();
            End();
        }

        public static void Start()
        {
            Title = GameTitle;
            WriteLine("Come one come all to the " + GameTitle + "!");
        }

        public static void ShowWelcome()
        {
            WriteLine("Welcome to this small game of trivia.");
            WriteLine("What is your name?");
            Player.Name = ReadLine();
            WriteLine("Nice to meet you, " + Player.Name + ".");
            WriteLine("Before we get to the game, I want to get to know you! What's your favorite animal?");
            Player.FavoriteAnimal = ReadLine();
            WriteLine("A(n) " + Player.FavoriteAnimal + "? Good pick.");
            WriteLine("Next and last question- what color do you like the most?");
            Player.ColorSelect = ReadLine();
            WriteLine("Ah, " + Player.ColorSelect + ", that makes sense.");
            WriteLine("Thank you for your input. Now onto the game!");
            WriteLine("NOTE: Make sure to capitalize the first letter of your responses. :)");

        }

        public static void ShowQuestion()
        {
            Clear();
            WriteLine("Question #1:");
            TriviaItem butterfly = new TriviaItem();
            butterfly.Question = "Monarch butterflies only eat milkweed. True or false?";
            WriteLine($"{butterfly.Question}");
            TriviaItem.Answer = ReadLine();
            if (TriviaItem.Answer == "True")
            {
                WriteLine("Correct!");
                Display.ShowPoints();
                
            }
            else
            {
                WriteLine("That was incorrect! The answer was TRUE.");
                WriteLine("Maybe you'll have better luck on the next question.");
                WriteLine("Press enter to continue.");
                ReadKey();
                Game.CheckResponse();
            }
            
        }

        public static void CheckResponse()
        {
            Clear();
            WriteLine("Question #2:");
            TriviaItem octopus = new TriviaItem();
            octopus.Question = "Octopuses have 8 tentacles. True or false?";
            WriteLine($"{octopus.Question}");
            TriviaItem.Answer = ReadLine();
            if (TriviaItem.Answer == "False")
            {
                WriteLine("That answer is correct!");
                Display.ShowNumberofQuestions();
            }
            else
            {
                WriteLine("Sorry, that wasn't the answer. The right response was FALSE.");
                WriteLine("Try again next time!");
                WriteLine("Press enter to continue.");
                ReadKey();
                Game.End();
            }

        }

        public static void End()
        {
            Clear();
            WriteLine("Thanks for playing! :)");
            WriteLine("Press the enter key to exit.");
            ReadKey();
        }
    }
}
