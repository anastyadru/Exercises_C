// ввела число, вывела в обратном порядке (358 - 853)

using System;

namespace Exercises
{
    public class Exercise3 : BaseExercise 
    {
        public override void Decide()
        {
            var a = 358;
            Console.Write(a % 10);

            while ((a /= 10) != 0)
                Console.Write(a % 10);
        }
    }
}