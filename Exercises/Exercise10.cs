// посчитала количество слов в строке

using System;

namespace Exercises
{
    public class Exercise10 : BaseExercise 
    {
        public override void Decide()
        {
            var text = "Буря мглою небо кроет здесь";
            var count = 0;

            var words = text.Split(' ');
            foreach (var word in words)
            {
                count += 1;
            }

            Console.WriteLine(count);
        }
    }
}