//Программа принимает 5 случайных цифр и определяет палиндром или нет полученное число

void FillArray(int[] col) //Заполним массив случайными числами
    {
        int lenth = col.Length;
        int index = 0;
        while(index < lenth)
        {
                col[index] = new Random().Next(0, 10);
                index++;
        }
    }

    void PrintArray(int[] coll)// Выводим на экран текущий массив
    {//В качестве аргумента приходит массив int[] col
        int count = coll.Length;
        int position = 0;
        while(position < count)
        {
            Console.Write(coll[position]);
            position++;
        }
    }

int [] array = new int[5];//Задаём длинну массива

for(int i = 1; i < 200; i++)
{
    Console.Write($"{i}. ");
    FillArray(array);
    PrintArray(array);
    if(array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("  Это палиндром.");        
        break;
    }
    else
    {
        Console.WriteLine("  Это не палиндром.");  
    }
}   