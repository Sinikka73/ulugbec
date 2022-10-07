// выдать количество цифр в числе.Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


Console.WriteLine("Введите число  ");  
int num =  Convert.ToInt32(Console.ReadLine());

if(num == 0) 
    {
        num = 1;
        Console.WriteLine($"Количество знаков в 0 составляет 1");
        
    }
else
    {
        if(num < 0)
    {   
        int num1 = 0;
        num1 = Math.Abs(num);
        int result = (int)Math.Log10(num1) + 1;
        Console.WriteLine($"Количество знаков в {num} составляет {result}");
    }
        else
    {
        int result = (int)Math.Log10(num) + 1; 
        Console.WriteLine($"Количество знаков в {num} составляет {result}");
    }
    }
