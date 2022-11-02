// преобразовала массив так, что последний поменялся с первым, предпосл со вторым и т.д.

using System;

namespace Exercises
{
    public class Exercise7 : BaseExercise 
    {
        public override void Decide()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Array.Reverse(array);

            Console.WriteLine(array);
        }
    }
}