// поменяла все символы "C" на "E" в строке

using System;

namespace Exercises
{
    public class Exercise12 : BaseExercise 
    {
        public override void Decide()
        {
            var text = "DFCCTHFCVHTTWECGRDKUFG";
            text = text.Replace("C", "E");

            Console.WriteLine(text);
        }
    }
}