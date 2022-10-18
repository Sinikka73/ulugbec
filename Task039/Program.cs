/* : Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
Console.WriteLine("Hello, World!");

int[] getRandomArray(int length, int former, int letter)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(former, letter +1);
    }
    return resultArray;
}

void printArray(int[] mainArray, string name)
{
    Console.WriteLine($"----------------{name}------------");
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

int[] mat = getRandomArray(10, 10, 99);

printArray(mat, "Прямой");

int[] reverseArray(int[] inArray)
    {
        int[] reversedArray = new int[inArray.Length];
        for (int i = 0; i < inArray.Length; i++)
        {
            reversedArray[i] = inArray[inArray.Length - 1 - i];
        }
        return reversedArray;
    }

int[] reversedMat = reverseArray(mat);

printArray(reversedMat, "Обратный");