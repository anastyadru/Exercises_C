// перевернула строку (компьютер - ретюьпмок)

using System;

namespace Exercises
{
    public class Exercise11 : BaseExercise 
    {
        public override void Decide()
        {
            var input = "компьютер";
            var inputarray = input.ToCharArray(); // отконвертировала строку в массив символа
            Array.Reverse(inputarray); // реверсировала
            var output = new string(inputarray); // создала новую строку из массива

            Console.WriteLine(output);
        }
    }
}