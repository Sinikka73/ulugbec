//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]



void FillArray(int[] col) //Заполним массив случайными числами
    {
        int lenth = col.Length;
        int index = 0;
        while(index < lenth)
        {
                col[index] = new Random().Next(0, 2);
                index++;
        }
    }
void PrintArray(int[] coll)// Выведем на экран текущий массив
    {//В качестве аргумента приходит массив int[] coll
        int count = coll.Length;
        int position = 0;
        while(position < count)
        {
           Console.Write($"{coll[position]}, ");
            position++;
            
        }
        
    }

int [] array = new int[8];//Задаём длинну массива, но сам массив не задан
FillArray(array);
Console.Clear();
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Hello, World!");
