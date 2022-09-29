
void getWeekend(int number)
{
    if(number == 6 || number == 7) Console.WriteLine("ДА");
    else Console.WriteLine("НЕТ");
}

Console.WriteLine("Введите порядковый номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());//Перевод строки в формат числа
getWeekend(num);


