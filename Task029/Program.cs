/* Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]*/

void getFillPrintArray(int usernumber)// Создаём новый массив и количество элементов (в массиве числа от 1 до 99), выводим на печать
    {
        int [] array = new int [usernumber];
        for(int i = 0; i < usernumber - 1; i++)
            {
                int index = 0;
                array [index] = new Random().Next(0, 99); 
                Console.Write($"{array[index]} ");
                index++;
            }
        array [usernumber-1] = new Random().Next(0, 99); 
        Console.Write($"{array[usernumber -1]}");
    }

Console.Clear();
Console.WriteLine($"Введите натуральное число, задавая длинну массива ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Массив из {num} элементов: ");
Console.Write("[");
getFillPrintArray(num);
Console.Write("]");


