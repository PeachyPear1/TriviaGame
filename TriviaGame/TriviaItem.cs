using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Console;

namespace TriviaGame
{
    public class TriviaItem
    {
        public string Question { get; set; }
        public static string Answer = "";

        /*public TriviaItem()
        *{
        *    CompareResponses();
        *    Continue();
        *    AwaitResponse();
        *}*/

        public static void ShowText()
        {
            WriteLine("First question...");
            ReadKey();
        }

        /*public static void CompareResponses()
        *{
        *
        *}
        *
        *public static void Continue()
        *{
        *
        *}
        *
        *public static void AwaitResponse()
        *{
        *   ReadLine();
        *}*/
    }
}
