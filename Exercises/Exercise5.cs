// реализовала метод, который получил число X и вернул все совершенные числа в диапазоне от 0..X (X=10 - 6)

using System;

namespace Exercises
{
    public class Exercise5 : BaseExercise 
    {
        static bool CheckNumber(int num)
        {
            var sum = 0;
            for (var i = 1; i < num; i++)
            {
                if (num % i == 0) sum += i;
            }

            return sum == num;
        }

        public override void Decide()
        {
            Console.Write("a=");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = int.Parse(Console.ReadLine());
            for (var i = a; i <= b; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadKey(true);
        }
    } 
}