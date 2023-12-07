/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();

int NewArrayLength(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GetNewArray(string[] array, int length)
{
    string[] newArray = new string[length];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newIndex] = array[i];
            newIndex++;

        }
    }
    return newArray;
}

void PrintArray(string[] array1, string[] array2)
{
    System.Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        System.Console.Write(array1[i]);
        if (i < array1.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("] -> ");
    System.Console.Write("[");
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.Write(array2[i]);
        if (i < array2.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

string[] sourceArray = {"Show", "must", "go", "on", "!"};
int newArrayLength = NewArrayLength(sourceArray);
string[] newArray = GetNewArray(sourceArray, newArrayLength);
PrintArray(sourceArray, newArray);