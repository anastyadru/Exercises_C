// получила сумму элементов одномер массива, которые а)больше числа М б) меньше числа N

using System;

namespace Exercises
{
    public class Exercise8 : BaseExercise 
    {
        public override void Decide()
        {
            var m = 2;
            var n = 10;
            var sum = 0;
            int[] array = { 1, 2, 32, 4, 5, 16, 7, 86 };

            for (var i = 0; i < array.Length; i++)
            {
                if ((array[i] > m) && (array[i] < n))
                {
                    sum += array[i];
                }
            }

            Console.Write(array + " ");
            Console.WriteLine(sum);
        }
    }
}