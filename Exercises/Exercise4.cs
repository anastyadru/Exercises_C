// реализовала метод, который получил число X и вернул все четные в диапазоне от 0..X (X=10 - 0,2,4,6,8)

using System;

namespace Exercises
{
    public class Exercise4 : BaseExercise 
    {
        public override void Decide()
        {
            var a = 0;
            var b = 10;
            if (a % 2 != 0) a++;
            {
                for (var i = a; i <= b; i += 2)
                    Console.WriteLine(i);
            }
        }
    }
}