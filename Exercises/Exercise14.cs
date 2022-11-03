// получила max элементы каждого столбца в двумер массиве

using System;

namespace Exercises
{
    public class Exercise14 : BaseExercise 
    {
        public override void Decide()
        {
            var array = new int[,] { { 1, 3, 5 }, { 2, 4, 6 } };
            var max = array[0, 0];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }

                Console.WriteLine(max);
            }
        }
    }
}