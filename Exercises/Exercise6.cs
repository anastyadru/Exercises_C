// получила сумму всех элем одномер массива, располож в четных и отдельно в нечет позициях

using System;

namespace Exercises
{
    public class Exercise6 : BaseExercise 
    {
        public override void Decide()
        {
            var array = new int[] { 6, 55, 7, 12, 88, 9 };
            var sum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    sum += 1;
            }

            Console.WriteLine(sum);
        }
    } 
}