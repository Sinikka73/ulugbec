void FillArray(int[] collection) //Заполним массив случайными числами
    {
        int lenth = collection.Length;
        int index = 0;
        while(index < lenth)
        {
                collection[index] = new Random().Next(1, 10);
                index++;
        }
    }

void PrintArray(int[] col)// Выводим на экран текущий массив
    {
        int count = col.Length;
        int position = 0;
        while(position < count)
        {
            Console.Write(col[position]);
            position++;
        }
    }

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];// создай новый массив,в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);




