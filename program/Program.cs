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
        userArray[i] = Convert.ToString(Console.ReadLine());
    }
    return userArray;
}

void printArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string[] ResultArray(string[] incomingArray)
{
    string[] resultArray = new string[incomingArray.Length];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i].Length <= 3)
        {
            resultArray[i] = incomingArray[i];
        } 
    }
    resultArray = resultArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    return resultArray;
}

Console.Write("Определите количество строк массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] userArray = fillArray(arraySize);
printArray(userArray);
string[] finalArray = ResultArray(userArray);
printArray(finalArray);




/*
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}
*/