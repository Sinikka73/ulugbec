/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите 
в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] multipliedArray(int[] incomeArray)
{
    int j = 0;
    int k = incomeArray.Length - 1;

    if (incomeArray.Length % 2 == 0)
    {
        int[] resultArray = new int[incomeArray.Length / 2];
        for (int i = 0; i < incomeArray.Length / 2; i++, k--, j++)
        {
            resultArray[j] = incomeArray[i] * incomeArray[k];
        }
        return resultArray;
    }
    else
    {
        int[] resultArray = new int[incomeArray.Length / 2 + 1];
        for (int i = 0; i < incomeArray.Length / 2; i++, k--, j++)
        {
            resultArray[j] = incomeArray[i] * incomeArray[k];
        }
        resultArray[j] = incomeArray[incomeArray.Length / 2];
        return resultArray;
    }
}
int[] workArray = getRandomArray(9, 1, 10);
printArray(workArray);
int[] endArray = multipliedArray(workArray);
printArray(endArray);