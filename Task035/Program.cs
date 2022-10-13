/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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

int countElementsArray(int [] mainArray)
{
    int count = 0;
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (mainArray[i] > 9 && mainArray[i] < 100)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Создали массив. ");
int[] workArray = getRandomArray(123, -123, 123);
printArray(workArray);
int result = countElementsArray(workArray);
Console.WriteLine($"Количество элементов от 10 до 99 в массиве [{result}] ");
