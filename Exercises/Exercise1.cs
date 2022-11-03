// с клавиат ввела 3 числа, вывела в порядке возрастания (4,7,2 - 2,4,7)

using System;

namespace Exercises
{ 
    public class Exercise1 : BaseExercise 
    {
        public override void Decide()
        {
            var a = 4;
            var b = 7;
            var c = 2;
            int[] nums = { a, b, c };
            Array.Sort(nums);
            {
                foreach (var num in nums)
                    Console.WriteLine(num);
            }
        }
    }
}
