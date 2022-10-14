/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


Console.WriteLine("Hello, World!");*/

int[] getRandomArray(int length, int former, int letter)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(former, letter + 1);
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

int countEvenNumberInMassive(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}

int[] workArray = getRandomArray(10, 100, 999);
int result = countEvenNumberInMassive(workArray);
printArray(workArray);
Console.WriteLine($"В массиве, заполненном случайными положительными трёхзначными числами, количество чётных чисел : [{result}]");