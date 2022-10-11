// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да


int [] getRandomArray(int length, int former, int letter)
    {
        int [] resultArray = new int [length];
        for (int i = 0; i < length; i++)
        {
            resultArray[i] = new Random().Next(former, letter + 1);
        }
        return resultArray;
    }

void printArray(int [] mainArray)
    {
        Console.Write("[");
        for (int i = 0; i < mainArray.Length; i++)
        {
            if(i < mainArray.Length - 1)
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

bool findNumberInArray(int [] searchArray, int number)
    {
        for (int i = 0; i < searchArray.Length; i++)
        {
            if(Math.Abs(searchArray[i]) == Math.Abs(number))
            return true;
        }
        return false;
    }

Console.WriteLine("Создали массив. "); 
int [] workArray = getRandomArray(10, -50, 50);
Console.WriteLine("Введите натуральное число для проверки его нахождения в массиве:  ");  
int num =  Convert.ToInt32(Console.ReadLine());

bool numberInArray =findNumberInArray(workArray, num);

Console.WriteLine($"{((numberInArray)?"Число присутствует в массиве":"Число  отсутствует в массиве")}");


printArray(workArray);       
Console.WriteLine("Hello, World!");


       