int getAnsewerDivid7And23Simult(int number)//Задаём функцмю делимого числа и её параметры
    {
        int result = number % 7 + number % 23;
        return result;    
    }
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());//Перевод строки в формат числа
int resul = getAnsewerDivid7And23Simult(num);
    if(resul == 0)
            {    
                Console.WriteLine("ДА");       
            }
    else Console.WriteLine("НЕТ");

