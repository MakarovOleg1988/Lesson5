using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разница в объеме памяти и максимально допустимых значениях.
            int myInt = 123; // MAX значения у данного типа 2147483647
            short myShort = 123; // MAX значения у данного типа 32767
            long myLong = 123; // MAX значения у данного типа 9223372036854775807

            // Так же разница в размере значений и весе 
            Double myDouble = 2.5; // для дробных значений
            float myFloat = 2.5f; // нужна заглушка f

            bool myBool = true; // только для значений True\False
            char myChar = '%'; // для символов !"№;%:?
            string myString = "Hello World";  // строка

            //Занимает места только 1 байт
            byte myBite = 254; // MAX значения у данного типа 

            int myInt2 = 6;

            // Явный и неявный тип результата (приведение результата)
            // В случае если значение результата будет больше максимального значения Int то результат будет Int -1
            myInt = myInt + myShort;
            myInt = (int)(long.MaxValue + myLong);
            //еще один вариант неявного приведения результата
            myLong = (long)(myDouble);

            //Выведение только целотипного количества, дробная часть отбрасывается полностью
            int myInt3 = myInt2 / 2;

            string myString2 = "Hello World" + myChar + myString + (myInt + myInt2);


            myShort =(short)(myShort + 1);
            //Либо ставим заглушку либо ставим используем неявное приведение результата
            myFloat = (float)(myFloat + 2.5);
            myFloat = myFloat + 2.5f;

            //Точность будет страдать (float and double более точные типы) 
            float myFloat2 = myLong;
            double myDouble2 = myLong;


            //Схема переходов типов
            //Short -> Int -> Long
            // Float -> Double
            // All types -> String

            Console.WriteLine(myString2);
            Console.WriteLine(myInt3);
            Console.WriteLine(myInt);
            Console.WriteLine(myLong);
        }
    }
}


