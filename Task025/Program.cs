// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getMultipliedNumber(int number, int stepen)
    {
        int result = 1;
        for(int i = 1; i <= stepen; i++)
            {   
                result = result * number;    
            }
        return result;
    }

Console.WriteLine("Программа возводит число в степень.");
Console.WriteLine("Введите натуральное число, возводимое в степень  ");  
int numuser =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - степень  ");  
int stepenuser =  Convert.ToInt32(Console.ReadLine());
int num = getMultipliedNumber(numuser, stepenuser);
Console.WriteLine($"[{numuser}] возведённое в степень [{stepenuser}] равно [{num}]");
