/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int sumOddIndex(int[] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(i % 2 != 0)
            {
                sum = sum + inArray[i];
            }
    }
    return sum;
}

int[] outArray = getRandomArray(6, -10, 11);
Console.WriteLine("Вмассиве :");
printArray(outArray);
int result = sumOddIndex(outArray);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях равна [{result}]");
