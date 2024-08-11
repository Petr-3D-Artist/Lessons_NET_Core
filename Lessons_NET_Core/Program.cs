using System;
namespace Lessons_NER_Core
{
    class Program
    {
        static void Main(string[] args)
        {


            //LESSON 39.ИНДЕКСЫ И ДИАПАЗОНЫ В C#

            /*
            int[] myArray = { 2, 3, 4, 5 }; // Элементы в массиве
            int[] myArray2 = myArray[1..4]; // Будет извлекать элементы с 1 по 4, можно написат ьи [..4]
                                            // Можно написать так от 5 элемента и до конца [5..]
            Console.WriteLine(myArray[^1]); // такой знак - ^1 - он будет извлекать наш массив с конца, первый элемент с конца, а 0 с начало 
                                            // ^ - это структура
            */

            //Example: Создание структуры:
            /*
            int[] myArray = { 2, 3, 4, 5 };
            Index myIndex = ^1; // Мы создаем индекс куда помещаем ^1 

            Console.WriteLine(myArray[myIndex]); // Сразу покажет жлемент последний из массива, с конца
            Console.WriteLine();
            Console.WriteLine($"value  {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
            */

            //Example: 2 способ cоздание структуры:
            /*
            int[] myArray = { 2, 3, 4, 5, 6, 7 };
            Index myIndex = new Index(3, false); // Это как ^3

            Console.WriteLine(myArray[myIndex]); 
            Console.WriteLine();
            Console.WriteLine($"value  {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
            */

            //Example: 3 способ cоздание структуры:
            /*
            int[] myArray = { 2, 3, 4, 5, 6, 7 };
            Range myRange = new Range(1,4); //или так = ^4..^1; //Range содержит в себе 2 индекса (1,4) это как 1..4
            int[] myArray2 = myArray[myRange];
            Console.WriteLine();
            */

            //Example: Работы со строками:


            string str = "Hello World";

            Console.WriteLine(str[^2..]); // Если в [0] укажем индекс, то он нам выведит первый символ H
                                          // Можно указывать [^1..] - с конца будет d, если написать [^2..] - то будет ld
                                          // Можно так [0..5]

























        }


    }

}  
  