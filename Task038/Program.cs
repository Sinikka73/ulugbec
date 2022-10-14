/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
Console.WriteLine("Hello, World!");*/

int[] getRandomArray(int length, int former, int letter)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(former, letter);
    }
    return resultArray;
}

void printArray(int[] mainArray)
{
    Console.Write("[");
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (i < mainArray.Length - 1)
        {
            Console.Write($"{mainArray[i]},");
        }
        else
        {
            Console.Write($"{mainArray[i]}");
        }

    }

    Console.WriteLine("]");
}

int getMaxMinDifference(int[] inArray)
{
    int nummax = 0;
    int nummin = inArray[inArray.Length - 1];
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] > nummax)
            nummax = inArray[i];
        if (inArray[i] < nummin)
            nummin = inArray[i];

    }
    int result = nummax - nummin;
    return result;
}
int[] workArray = getRandomArray(5, 1, 11);
printArray(workArray);
int end = getMaxMinDifference(workArray);
Console.WriteLine($"Разница между макс. мин. элементами в массиве равна [{end}] ");