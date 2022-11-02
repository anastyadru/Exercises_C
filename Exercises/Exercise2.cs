// реализовала метод, вычисляющий факториал из числа введенного с клавиатуры (5 - 120)

using System;

namespace Exercises
{
    public class Exercise2 : BaseExercise 
    {
        public override void Decide()
        {
            var a = 5;
            var factorial = 1;
            for (var i = 2; i <= a; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial" + a + " = " + factorial);
            Console.Read();
        }
    } 
}