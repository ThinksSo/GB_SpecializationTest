/* Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["Hello", "2", "world", ":-)"] -> ["2", ";-)*]
['1234", "1567", "-2", "computer science"] -> ["-2"]
['Russia", "Denmark", "Razan"] -> []
*/

void ArrayLess3()
{
    Console.WriteLine("\n \t Array of elements with length less than 3");
    string[] sourceArray = {"Hi", "how", "are", "you", "?", "What", "are", "you", "doing", "?"};
    string[] finalArray = new string [sourceArray.Length];
    // var finalArray = Array.Empty<string>();
    int n = 0;

    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            finalArray[n] = sourceArray[i];
            n++;
        }
    }

    PrintArray(sourceArray);
    Console.Write("-> ");
    PrintArray(finalArray);
    Console.WriteLine();
}

ArrayLess3();


void PrintArray(string[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    } 
    Console.WriteLine();
}