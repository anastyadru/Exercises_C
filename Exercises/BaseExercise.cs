using System;

namespace Exercises
{
    public abstract class BaseExercise

    {
        public abstract void Decide();
    }

    
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите номер задачи: "); 
                var i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        BaseExercise exercise1 = new Exercise1();
                        exercise1.Decide();
                        break;

                    case 2:
                        BaseExercise exercise2 = new Exercise2();
                        exercise2.Decide();
                        break;
                    
                    case 3:
                        BaseExercise exercise3 = new Exercise3();
                        exercise3.Decide();
                        break;
                    
                    case 4:
                        BaseExercise exercise4 = new Exercise4();
                        exercise4.Decide();
                        break;
                    
                    case 5:
                        BaseExercise exercise5 = new Exercise5();
                        exercise5.Decide();
                        break;
                    
                    case 6:
                        BaseExercise exercise6 = new Exercise6();
                        exercise6.Decide();
                        break;
                    
                    case 7:
                        BaseExercise exercise7 = new Exercise7();
                        exercise7.Decide();
                        break;
                    
                    case 8:
                        BaseExercise exercise8 = new Exercise8();
                        exercise8.Decide();
                        break;
                    
                    case 9:
                        BaseExercise exercise9 = new Exercise9();
                        exercise9.Decide();
                        break;
                    
                    case 10:
                        BaseExercise exercise10 = new Exercise10();
                        exercise10.Decide();
                        break;
                    
                    case 11:
                        BaseExercise exercise11 = new Exercise11();
                        exercise11.Decide();
                        break;
                    
                    case 12:
                        BaseExercise exercise12 = new Exercise12();
                        exercise12.Decide();
                        break;
                    
                    case 13:
                        BaseExercise exercise13 = new Exercise13();
                        exercise13.Decide();
                        break;
                    
                    case 14:
                        BaseExercise exercise14 = new Exercise14();
                        exercise14.Decide();
                        break;
                }
            } 
            while(true); 
        }
    }
}


    