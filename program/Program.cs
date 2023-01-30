
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.WriteLine("Введите слова");
string input = Console.ReadLine();
string[] words = input.Split(" ");

string[] ArraySort(string[] array)
{
    string[] NewArray = new string[array.Length];
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[x] = array[i];
            x++;
        }
    }
    return NewArray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string[] NewWords = ArraySort(words);
PrintArray(NewWords);