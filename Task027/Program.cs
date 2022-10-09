// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите натуральное число  "); 

int getSumOfNumbers(int putnumber)
    {
        int sum = 0;
        int number = putnumber;
        while(number > 0)
            {
              sum = sum + number % 10;
              number = number / 10;  
              
            }
        return sum;
    }

int numberuser =  Convert.ToInt32(Console.ReadLine());  
int num = getSumOfNumbers( numberuser);
Console.WriteLine($"Сумма цифр числа {numberuser} равна {num}");
