// посчитала количество символов "A" в строке

using System;

namespace Exercises
{
    public class Exercise9 : BaseExercise 
    {
        public override void Decide()
        {
            var str = "ADGFGTHAGFDAAFHG";
            var count = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A')
                    count += 1;
            }

            Console.WriteLine(count);
        }
    }
}