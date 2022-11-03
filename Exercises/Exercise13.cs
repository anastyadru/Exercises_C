// посчитала количество слов, которые начинаются на букву "К", в строке

using System;

namespace Exercises
{
    public class Exercise13 : BaseExercise 
    {
        public override void Decide()
        {
            var text = "Катя живет в квартире";
            var symbol = "К";
            var count = 0;

            var words = text.Split(' ');
            foreach (var word in words)
            {
                if (word.ToUpper().StartsWith(symbol, StringComparison.CurrentCulture))
                    count += 1;
            }

            Console.WriteLine(count);
        }
    }
}