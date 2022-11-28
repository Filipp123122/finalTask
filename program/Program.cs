/*
Задача.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []     
*/

string[] fillArray(int arraySize)
{
    string[] userArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        userArray[i] = Console.ReadLine();
    }
    return userArray;
}

void printArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write($"\"{incomingArray[i]}\"");
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int ArraySizeLength(string[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}

string[] ResultArray(string[] incomingArray, int arraySize)
{
    string[] resultArray = new string[arraySize];
    int j = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i].Length <= 3)
        {
            resultArray[j] = incomingArray[i];
            j++;
        } 
    }
    return resultArray;
}

Console.Write("Определите количество строк массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] userArray = fillArray(arraySize);
printArray(userArray);
int arrayLength = ArraySizeLength(userArray);
string[] finalArray = ResultArray(userArray,arrayLength);
printArray(finalArray);
