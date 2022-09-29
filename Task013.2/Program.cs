int getDigit3FromNumber(int number)//Задаём параметры функции
{
    {
        while(number > 999)
        number = number / 10;    
    }
    int digit3 = number % 10;
    return digit3;
}   

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());//Перевод строки в формат числа

if(num > 99)
    {
         int result = getDigit3FromNumber(num);  
         Console.WriteLine(result);
    }
else
    {
        Console.WriteLine("Третьей цифры нет");
    }
