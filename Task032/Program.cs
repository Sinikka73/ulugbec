//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


int [] getRandomArray(int length, int first, int last)
    {
        int [] randomArray = new int [length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = new Random().Next(first, last +1);
        }
        return randomArray;
    }

void printArray(int[] incomingArray)
    {
        Console.Write($"[");
        for (int i = 0; i < incomingArray.Length; i++)
            {
                Console.Write(incomingArray[i]);
                if(i < incomingArray.Length - 1)
                    {
                        Console.Write(", ");
                    }
            }
        Console.WriteLine("]");    
    }

int [] getInvertNumber(int [] startArray)
    {
        int [] resulArray = new int [startArray.Length];
        for (int i = 0; i < startArray.Length; i++)
        {
            resulArray[i] = startArray[i] * -1;
        }
        return resulArray;
    }

Console.Clear();
Console.WriteLine("Программа выдаёт массив, заданной длины и конвертирует знак у каждого элемента.");
int [] currentArray = getRandomArray(10, -10, 10);
printArray(currentArray);
int [] invertedArray = getInvertNumber(currentArray);
printArray(invertedArray);
Console.WriteLine("Hello, World!");
